using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

// Note: I would like to explain some on my code was helped by a google search from other users examples simular probelems from StackOverview
// undersnading the foreach loop and from Nilesh Jadav { ht tps://www.c-sharpcorner.com/UploadFile/009464/save-data-to-text-file-in-windows-form-using-C-Sharp/}
// giving examples of file saving and creating a streamwriter. Most was gathered through our textbook with examples. I studied the loops and terms
// durring the writing of code. All varables and instances are mine.
namespace Week_3_Activity_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private async void button1_Click(object sender, EventArgs e)
        {
            //Create a Streamreader for file upload option from user.
            StreamReader fileSelection;
            //Create a datatype with varable name to pass the file too.
            String document;
            // If user clicks select on file dialog file opens.
            if (userOpenFile.ShowDialog() == DialogResult.OK)
            {
                // Open the selected file.
                fileSelection = File.OpenText(userOpenFile.FileName);
                // Pass text document to varable document.
                document = fileSelection.ReadLine();
                // Send text document varable to textbox.
                fullFileView.Text = document;
                // Create a string method to lower all chacters to lower case.
                lowerCase.Text = document.ToLower();
                // Create an array to sent text using the split method.
                string[] accMedia = document.Split(new[] { " " }, StringSplitOptions.None);
                // Create a datatype string varable *Not referencing! 
                string media = "";
                // Create a counter.
                int control = 0;
                // Build a foreach loop to search through the array.
                foreach (String word in accMedia)
                {   // Create a condintanal statement to find word that has the longest chacter.
                    if (word.Length > control)
                    {   // Pass longest word to new string varable.
                        media = word;
                        // Count word length.
                        control = word.Length;
                    }
                }
                // Send longest word to texbox on user GUI.
                longestWord.Text = media;


                // Create a array of Characters.
                char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
                // Create a special array of Characters.
                char[] special = { ' ', '.', ',', '!', '?', ':', ';', '(', ')', '\t' };
                // Create a varable to store search results.
                string alphabet = "";
                // Create a string array to store text files using the split option.
                string[] parts = document.Split(special, StringSplitOptions.RemoveEmptyEntries);
                // Create a varable to store vowels in words that has the most vowels count
                var mostVowels = 0;
                // create a for loop to count vowels the entire length of the array.
                for (int i = 0; i < parts.Length; i++)
                {   // total words with vowels count.
                    var part = parts[i];
                    // Declare numberofVowels for count each WORD.
                    var numberOfVowels = 0;
                    // foreeach loop to pull count from array list.
                    foreach (var vowel in vowels)
                    {   //Conditional statement to store word with vowels and increment 1.
                        if (part.Contains(vowel)) numberOfVowels++;
                    }
                    // conditinal stament if stored word vowels is smaller than the total of other vowels in document.
                    if (mostVowels < numberOfVowels)
                    { // Add new word with most vowels
                        mostVowels = i;
                        // Store longest word.
                        alphabet = part;
                    }
                }
                // Send longest word with most vowels to GUI display.
                wordWithMostVowels.Text = alphabet;

            }
            else
            {
                //If user cancels upload file, pop up displayed.
                MessageBox.Show("Operation canceled.");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        //save data in text box dialog box connection.
        private void button1_Click_1(object sender, EventArgs e)
        {

            //If user clicks upload, upload document to text box.
            if (saveToFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Create a streamwriter opject and store file accoding to user preference name.
                TextWriter userSaveFile = new StreamWriter(saveToFileDialog.FileName);
                // Write displayed result on text pox in this manner.
                userSaveFile.Write("Word with most Vowels: "+ wordWithMostVowels.Text + " Longest Word: " + longestWord.Text + " Full File: " + fullFileView.Text + " Lower Case: " + lowerCase.Text);
                // Close upload to new file.
                userSaveFile.Close();
            }
            else
                //If user cancels file save. message displayed.
                MessageBox.Show("Save Cancel");
            {

            }
        }
        // Close program.
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Reset fields and another file check.
        private void button1_Click_2(object sender, EventArgs e)
        {
            // Clear the text fields
            fullFileView.Text = "";
            lowerCase.Text = "";
            wordWithMostVowels.Text = "";
            longestWord.Text = "";
            //Set fucus to fullFileView textbox
            fullFileView.Focus();
        }
    }
}
