using System;
using System.Collections.Generic;
using System.Linq;

namespace AfterEffects
{
    public class Hebrew_Manipulation
    {
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static string HebrewStringModify_New(string s)
        {
            List<string> FullText = new List<string>();
            var txtInput = s;
            var line = txtInput.Split(' ');
            foreach (string word in line)
            {
                string tempWord = string.Empty;

                if (HebrewDetection(word))
                {
                    tempWord = Reverse(word);

                    //txtTestOutput.Text = "Hebrew Found";
                }
                else
                {
                    tempWord = word;
                }

                if (tempWord.Contains(","))
                {
                    string x = tempWord.Replace(",", "");
                    string y = "," + x;
                    tempWord = y;
                }


                if (tempWord.Contains("-"))
                {
                    var MixString = word.Split('-');

                    List<string> DevidedString = new List<string>();
                    foreach (string inner_word in MixString)
                    {
                        try
                        {
                            var x = Convert.ToDouble(inner_word);
                            DevidedString.Add(inner_word);
                        }
                        catch (Exception)
                        {
                            DevidedString.Reverse();
                            DevidedString.Add(inner_word);
                        }
                    }

                    DevidedString.Reverse();
                    string combindedString2 = string.Join("-", DevidedString.ToArray());
                    tempWord = combindedString2;
                }


                if (tempWord.Contains(":"))
                {
                    // Split and reverse number if double????
                }

                FullText.Add(tempWord);
            }
            FullText.Reverse();
            string combindedString = string.Join(" ", FullText.ToArray());
            combindedString = Reverse(combindedString);
            return combindedString;
        }

        static string HebrewStringModify(string s)
        {
            List<string> list = new List<string>();
            List<string> mix_string_list = new List<string>();
            var line = s.Split(' ');
            foreach (string word in line)
            {
                if (word.Contains("-"))
                {
                    var MixString = word.Split('-');
                    foreach (string inner_word in MixString)
                    {
                        //MessageBox.Show(inner_word);
                        try
                        {
                            Convert.ToInt32(inner_word);
                            string rString = Reverse(inner_word);
                            mix_string_list.Add(rString);
                        }
                        catch (Exception)
                        {
                            mix_string_list.Add(inner_word);
                        }
                    }
                    string combindedString2 = string.Join("-", mix_string_list.ToArray());
                    list.Add(combindedString2);
                }
                else
                {
                    try
                    {
                        Convert.ToInt32(word);
                        string rString = Reverse(word);
                        list.Add(rString);
                    }
                    catch (Exception)
                    {
                        list.Add(word);
                    }
                }
            }
            string combindedString = string.Join(" ", list.ToArray());
            combindedString = Reverse(combindedString);
            return combindedString;
        }

        static bool HebrewDetection(string value)
        {
            bool found = false;
            #region Adding hebrew letters to Char List
            List<Char> hebrewLettersList = new List<char>();
            string hebrewLetters = "אבגדהוזחטיכךלמםנןסעפףצץקרשת";
            foreach (var letter in hebrewLetters)
            {
                hebrewLettersList.Add(letter);
            }
            #endregion

            //txtInputString.Text = "abcאdבef";
            var input = value;

            for (int i = 0; i < hebrewLettersList.Count; i++)
            {
                if (input.Contains(hebrewLettersList[i]))
                {
                    found = true;
                    break;
                }
            }

            //foreach (var item in input)
            //{
            //    for (int i = 0; i < hebrewLettersList.Count; i++)
            //    {
            //        if (item == hebrewLettersList[i])
            //        {
            //            found = true;
            //            break;
            //        }
            //    }
            //}

            //if (found)
            //    return true;
            //else
            //    return false;
            return found;
        }
    }
}
