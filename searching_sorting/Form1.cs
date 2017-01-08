using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace searching_sorting
{
    public partial class Form1 : Form
    {
        private string[] textArray = new string[1000000]; //create an instance of textArray so it can be used multiple times and accessible in all functions

        public Form1()
        {
            InitializeComponent();  //initialize all xaml UI designs and controls
            

        }
        
        // function to handle the find_click event
        private void Find_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt16(arrayIndex.Text);//convert the arrayIndex to a 16 bit integer
                value.Text = getValue(textArray, x);//call the getValue function and assign the result to the label:value
                value.Visible = true;   //make value visible
            }
            catch (Exception)
            {
                MessageBox.Show("Entered Array Index Out of Bound./nEnter another number");
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //create an array of strings 
            var listOfStrings = new List<string>();
           textArray = listOfStrings.ToArray();
           
                //select the file to be converted to array
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)                  // if the openFiledialog has finished execution
                {
                    selectedFileName.Text = openFileDialog1.FileName;
                    selectedFileName.Visible = true;
                    string file = openFileDialog1.FileName; //saves the input file from the openFiledialog window 
                    try
                    {
                        string text = File.ReadAllText(file); //convert the input file a set of strings

                        textArray = text.Split(' '); //converts the set of strings in arrays delimited by whitespaces
                        arrayBox.Text = text;
                        arraySize.Text = (textArray.Length - 1).ToString();
                        label5.Visible = true;
                        arraySize.Visible = true;
                    }
                //throw exception in case of an error
                catch (Exception)
                    {

                        MessageBox.Show("Choose a valid file type");
                        
                    }
                }
            
            
        }
        // funtion to get the requested value from an array
        public String getValue(string[] a, int index)
        {
            string output = a[index];
            return output;
        }

        // Make the needed controls visible if the user checks the checkbox: Enter array manually
        private void manualInput_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = true;
            manualArray.Visible = true;
            done.Visible = true;
        }
        //function to convert the manual inputs to an accessible and formatable array
        private void done_Click(object sender, EventArgs e)
        {
            try
            {
                string text = manualArray.Text;
                textArray = text.Split(' '); 
                
            }
            catch (Exception)
            {
                MessageBox.Show("Enter a valid input and separate by whitespaces only");
                
            }
        }
        //function to get the largest value and index of the largest value
        private void largest_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                value.Text = textArray.Max().ToString();
                arrayIndex.Text = textArray.ToList().IndexOf(value.Text).ToString();
                value.Visible = true;   //make value visible
            }
            //handle error
            catch (Exception)
            {
                MessageBox.Show("Select a file or enter the array manually by clicking the Enter array manually checkBox");
                
            }
           

        }
        //function to get the smallest value and index of the smallest value
        private void minimum_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                value.Text = textArray.Min().ToString();
                arrayIndex.Text = textArray.ToList().IndexOf(value.Text).ToString();
                value.Visible = true;   //make value visible
            }
            //handle error
            catch (Exception)
            {
                MessageBox.Show("Select a file or enter the array manually by clicking the Enter array manually checkBox");
                
            }
            
        }
        //reassign textArray to values in manual array textBox
        private void useManual_CheckedChanged(object sender, EventArgs e)
        {
                string text = manualArray.Text;
                textArray = text.Split(' ');
        }
        //reassign textArray to values in manual array textBox
        private void useInput_CheckedChanged(object sender, EventArgs e)
        {
            string text = arrayBox.Text;
            textArray = text.Split(' ');
        }
    }
}
