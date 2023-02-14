using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace GP_Preset_Sorter
{
    public partial class Form1 : Form
    {
        //Max numbers of presets that will be in the prst file
        public const int MaxPresets = 99;
        public XmlDocument rootXmlDocument;

        //List used for storing the actual preset XML
        public List<XmlNode> presetsListXml = new List<XmlNode>();
        //List used for showing the preset names in the ListView
        public List<String> presetsListItems = new List<String>();

        public Form1()
        {
            InitializeComponent();
        }

        private void loadPresetsFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = LoadPresetsFile();
            XmlNodeList xmlPresets = ReadXMLFileUsingXMLDocument(filePath);
            if (xmlPresets != null)
            {
                filePath_label2.Text = filePath;
                filePath_label1.Visible = true;
                filePath_label2.Visible = true;

                LoadXMLIntoList(xmlPresets);
            }
        }

        internal XmlNodeList ReadXMLFileUsingXMLDocument(string filePath)
        {
            if (filePath != "")
            {
                try
                {
                    rootXmlDocument = new XmlDocument();
                    rootXmlDocument.Load(filePath);
                    XmlNodeList xmlNodeList = rootXmlDocument.DocumentElement.SelectNodes("/GP-100/presets");

                    return xmlNodeList;
                }
                catch (System.Xml.XmlException e)
                {
                    MessageBox.Show("There was a problem with the structure of the file. Make sure it's a compatible Valeton GP-100 export file. \n\nError: " + e.Message);
                    return null;
                }
                catch (Exception e)
                {
                    MessageBox.Show("There was a problem opening the file. Make sure it's a compatible Valeton GP-100 export file. \n\nError: " + e.Message);
                    return null;
                }
                
            }

            return null;
   
        }

        private void LoadXMLIntoList (XmlNodeList xmlPresets)
        {
            presets_listBox.DataSource = null;
            presets_listBox.Items.Clear();
            presetsListItems.Clear();
            presetsListXml.Clear();

            for (int i = 0; i < xmlPresets.Count; i++)
            {
                //To show the whole XML preset
                //MessageBox.Show(xmlPresets[i].OuterXml);
                string presetNumber;
                if (i < 9) { presetNumber = "0" + (i + 1); }
                else { presetNumber = (i+1).ToString(); }
                string presetItemTitle = "P" + presetNumber + ". " + xmlPresets[i].Attributes.GetNamedItem("ppName").InnerText;
                presetsListItems.Add(presetItemTitle);
                presetsListXml.Add(xmlPresets[i]);
            }

            presets_listBox.DataSource = presetsListItems;

            exportPresetsFileToolStripMenuItem.Enabled = true;
        }

        private string LoadPresetsFile()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Browse Valeton GP Presets Files";
            openFileDialog1.DefaultExt = "prst";
            openFileDialog1.Filter = "prst files (*.prst)|*.prst|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();

            return openFileDialog1.FileName;

        }

        private void exportPresetsFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog ExportPresetsFileDialog = new SaveFileDialog();
            ExportPresetsFileDialog.DefaultExt = "prst";
            ExportPresetsFileDialog.Filter = "prst files (*.prst)|*.prst";
            ExportPresetsFileDialog.ShowDialog();
            String filePath = ExportPresetsFileDialog.FileName;

            if(filePath != "")
            {
                XmlNodeList xmlNodeList = rootXmlDocument.DocumentElement.SelectNodes("/GP-100/presets");
                foreach (XmlNode xmlPreset in xmlNodeList)
                {
                    rootXmlDocument.DocumentElement.SelectSingleNode("/GP-100").RemoveChild(xmlPreset);
                }

                //Add the presets in the new order
                for (int i = 0; i < presetsListXml.Count; i++)
                {
                    //First, update the ppID XML attribute
                    presetsListXml[i].Attributes["ppID"].Value = i.ToString();
                    rootXmlDocument.DocumentElement.SelectSingleNode("/GP-100").AppendChild(presetsListXml[i]);
                }

                rootXmlDocument.Save(filePath);
            }

        }

        private void moveItemsUp (ListBox.SelectedIndexCollection selectedIndices)
        {

            List<int> indices = new List<int>();
            for (int i = 0; i < selectedIndices.Count; i++)
            {
                indices.Add(selectedIndices[i]);
            }
            //If we're trying to move further the limit (preset number 0)
            if (selectedIndices[0] == 0)
            {
                return;
            }

            int index;

            for (int i = 0; i < selectedIndices.Count; i++)
            {
                index = selectedIndices[i];
                
                //Update the list in the listbox
                string presetName = presetsListItems[index];
                presetsListItems.RemoveAt(index);
                presetsListItems.Insert(index - 1, presetName);
                
                //Update the presets XML list
                XmlNode presetXml = presetsListXml[index];
                presetsListXml.RemoveAt(index);
                presetsListXml.Insert(index - 1, presetXml);
                
            }

            //Update the new selected items in the listbox
            
            presets_listBox.DataSource = null;
            presets_listBox.DataSource = presetsListItems;
            presets_listBox.ClearSelected();
            for (int i = 0; i < indices.Count; i++)
            {
                presets_listBox.SetSelected(indices[i] - 1, true);
            }
        }

        private void moveItemsDown(ListBox.SelectedIndexCollection selectedIndices)
        {
            List<int> indices = new List<int>();
            for (int i = 0; i < selectedIndices.Count; i++)
            {
                indices.Add(selectedIndices[i]);
            }
            //If we're trying to move further the limit (preset number 99)
            if (selectedIndices[(selectedIndices.Count - 1)] == (MaxPresets - 1))
            {
                return;
            }

            int index;
            //MessageBox.Show("Total selected is " + selectedIndices.Count);

            for (int i = (selectedIndices.Count - 1); i >=0 ; i--)
            {
                //MessageBox.Show("i=" + i);
                index = selectedIndices[i];
                //MessageBox.Show("Moving item at index " + index);
                //Update the list in the listbox
                string presetName = presetsListItems[index];
                presetsListItems.RemoveAt(index);
                presetsListItems.Insert(index + 1, presetName);

                //Update the presets XML list
                XmlNode presetXml = presetsListXml[index];
                presetsListXml.RemoveAt(index);
                presetsListXml.Insert(index + 1, presetXml);
            }

            //Update the new selected items in the listbox
            
            presets_listBox.DataSource = null;
            presets_listBox.DataSource = presetsListItems;
            presets_listBox.ClearSelected();
            //MessageBox.Show("now we need to still update " + indices.Count + " selected items");
            for (int i = 0; i < indices.Count; i++)
            {
                //MessageBox.Show("updating selected item with index " + (indices[i]+1));
                presets_listBox.SetSelected(indices[i] + 1, true);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            moveItemsUp(presets_listBox.SelectedIndices);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            moveItemsDown(presets_listBox.SelectedIndices);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();

            about.Show();

        }
    }
}
