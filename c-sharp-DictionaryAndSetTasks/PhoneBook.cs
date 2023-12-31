﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_DictionaryAndSetTasks
{
    /*
        Task 3: Phone Book
            Create a phone book program that allows users to add, search, and delete contacts.Use a Dictionary to
            store the contacts, where the keys are the names and the values are the phone numbers.Implement
            functions to add a contact, search for a contact by name, and delete a contact by name. 
        */
    internal class PhoneBook
    {
        Dictionary<string, string> contactInfo = new Dictionary<string, string>();//

        public void add(string name, string phoneNumber)
        {
            contactInfo[name] = phoneNumber;
            Console.WriteLine($"Contact '{name}' has been added with phone number '{phoneNumber}'.");

        }
        public void remove(string name)
        {
            if (contactInfo.ContainsKey(name))
            {
                contactInfo.Remove(name);
                Console.WriteLine($"Contact '{name}' has been deleted.");
            }
            else
            {
                Console.WriteLine($"Contact '{name}' not found.");
            }
        }

        public void search(string name) 
        {
            if (contactInfo.ContainsKey(name))
            {
                string phoneNumber = contactInfo[name];
                Console.WriteLine($"Contact found: '{name}' with phone number '{phoneNumber}'.");
            }
            else
            {
                Console.WriteLine($"Contact '{name}' not found.");
            }
        }
        public void edit(string name, string newPhoneNumber)
        {
            if (contactInfo.ContainsKey(name))
            {
                contactInfo[name] = newPhoneNumber;
                Console.WriteLine($"Contact '{name}' has been edited with new phone number '{newPhoneNumber}'.");
            }
            else
            {
                Console.WriteLine($"Contact '{name}' not found.");
            }
        }

    }
}
