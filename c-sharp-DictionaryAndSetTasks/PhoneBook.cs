using System;
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
        Dictionary<string, string> contactInfo = new Dictionary<string, string>();

        public void add(string name, string phoneNumber)
        {
            contactInfo[name] = name;
            contactInfo[phoneNumber] = phoneNumber;
        }
        public string remove(string name)
        {
            string? phoneNumber = null;
           if(contactInfo.Remove(name,out phoneNumber))
            {
                return phoneNumber;

            }
            return null;
        }

        public string search(string name) 
        { 
            if(contactInfo.TryGetValue(name,out name))
            {
                return name;
            }
            return null;
        }
       
    }
}
