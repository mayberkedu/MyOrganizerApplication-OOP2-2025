﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MyOrganizerApplication
{
    public class Functions
    {
        //Asla bir nesne üretilmesini istemiyoruz ortak bir class 
        private Functions() { }
        
        private readonly static string EMAIL_PATTERN = @"^[A-Z0-9._%+-]+@[A-Z0-9.-]+.(com|org|net|edu|gov|mil|biz|info|mobi)(.[A-Z]{2})?$";
        public static bool isEmailValid(string emailInput)
        {
            Regex regex = new Regex(EMAIL_PATTERN, RegexOptions.IgnoreCase);
            return regex.IsMatch(emailInput);
        }
        public static string ImageToBase64(string path)
        {
            try
            {
                byte[] imageArray = System.IO.File.ReadAllBytes(path);
                string base64String = Convert.ToBase64String(imageArray);
                return base64String;
            }
            catch (Exception)
            {
                return null;
            }

        }
        public static Image Base64ToImage(string base64String)
        {
            // Convert base 64 string to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            // Convert byte[] to Image
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }
        public static void LoadPhoneBook(List<Phone> phoneList, string path)
        {
            phoneList.Clear();
            try
            {
                using (var reader = new StreamReader(path))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        var values = line.Split(',');
                        string user = values[0];
                        string name = values[1];
                        string surname = values[2];
                        string number = values[3];
                        string address = values[4];
                        string description = values[5];
                        string mail = values[6];
                        phoneList.Add(new Phone(user, name, surname, number, address, description, mail));
                    }
                }
            }
            catch (Exception)
            {
            }
        }



        public static void SavePhoneBook(List<Phone> phoneList, string path)
        {
            using (var writer = new StreamWriter(path))
            {
                foreach (Phone number in phoneList)
                {
                    writer.WriteLine(number.toString());
                }
            }
        }
        public static void SaveNotebook(List<Notes> listNote, string path)
        {
            using (var writer = new StreamWriter(path))
            {
                foreach (Notes item in listNote)
                {
                    if (item.Note.Contains(System.Environment.NewLine))
                    {
                        item.Note = Regex.Escape(item.Note);
                        if (item.Note.Contains(","))
                        {
                            item.Note = item.Note.Replace(",", "#");
                            writer.WriteLine(item.toString());
                        }
                        else
                        {
                            writer.WriteLine(item.toString());
                        }
                    }
                    else
                    {
                        if (item.Note.Contains(","))
                        {
                            item.Note = item.Note.Replace(",", "#");
                        }
                        if (item.Note.Contains("\\n"))
                        {
                            item.Note = Regex.Escape(item.Note);
                        }
                        else
                        {
                            writer.WriteLine(item.toString());
                        }
                    }
                }
            }
        }
        
        public static void LoadNotebook(List<Notes> notebook,string path)
        {
            notebook.Clear();
            try
            {
                using (var reader = new StreamReader(path))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        var values = line.Split(',');
                        string user = values[0];
                        string note = values[1];
                        notebook.Add(new Notes(user,note));
                    }
                }
            }
            catch (Exception)
            {
            }
        }
        
        public static void LoadCsv(List<Kullanici> userList, string path)
        {
            userList.Clear();
            try
            {
                using (var reader = new StreamReader(path))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        var values = line.Split(',');
                        string username = values[0];
                        string password = values[1];
                        bool rememberme = (values[2]).Equals("1") ? true : false;
                        string usertypes = values[3];
                        string name = values[4];
                        string surname = values[5];
                        string phonenumber = values[6];
                        string address = values[7];
                        if (address.Contains("#"))
                        {
                            address = address.Replace("#", ",");
                        }
                        string email = values[8];
                        string photo = values[9];
                        string salary = values[10];
                        userList.Add(new Kullanici(username, password, rememberme, usertypes, name, surname, phonenumber, address, email, photo, salary));
                    }
                }
            }
            catch (Exception)
            {
            }
        }
        public static void SaveCsv(List<Kullanici> userList, string path)
        {
            using (var writer = new StreamWriter(path))
            {
                foreach (Kullanici user in userList)
                {
                    if (user.Address.Contains(","))
                    {
                        user.Address = user.Address.Replace(",", "#");
                    }
                    writer.WriteLine(user.toString());
                }
            }
        }
        public static void LoadReminder(List<Alarm> alarmList, string path)
        {
            alarmList.Clear();
            try
            {
                using (var reader = new StreamReader(path))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        var values = line.Split(',');
                        string user = values[0];
                        string type = values[1];
                        string day = values[2];
                        string time = values[3];
                        string summary = values[4];
                        string description = values[5];
                        alarmList.Add(new Alarm(user, type, day, time, summary, description));
                    }
                }
            }
            catch (Exception)
            {
            }
        }
        public static void SaveReminder(List<Alarm> alarmList, string path)
        {
            using (var writer = new StreamWriter(path))
            {
                foreach (Alarm alarm in alarmList)
                {
                    writer.WriteLine(alarm.toString());
                }
            }
        }
        public static void Shake(Form form)
        {
            var original = form.Location;
            var rnd = new Random(1337);
            const int shake_amplitude = 10;
            for (int i = 0; i < 70; i++)
            {
                form.Location = new Point(original.X + rnd.Next(-shake_amplitude, shake_amplitude), original.Y + rnd.Next(-shake_amplitude, shake_amplitude));
                System.Threading.Thread.Sleep(20);
                form.Location = original;
            }
        }
        public static void RingAlarm()
        {
            Functions.LoadReminder(Alarm.alarmList, Reminder.path);
            String nowTime = DateTime.Now.ToLongDateString() + "," + DateTime.Now.ToLongTimeString();
            foreach (var item in Alarm.alarmList)
            {
                if (nowTime == item.Day + "," + item.Time)
                {
                    Functions.Shake(Form.ActiveForm);
                    Form.ActiveForm.Text = item.Summary;
                    break;
                }
            }
        }
    }
}
