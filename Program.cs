﻿using System;

class Program
{
    static void Main()
    {
        string[] adjectives = { "Senior", "Lead", "Dynamic", "Unpaid", "Future", "Virtual" };
        string[] roles = { "Data Wrangler", "Pixel Architect", "Spreadsheet Ninja", "Cloud Whisperer", "Tech Wizard" };

        Random rand = new Random();
        string adjective = adjectives[rand.Next(adjectives.Length)];
        string role = roles[rand.Next(roles.Length)];

        string jobTitle = $"{adjective} {role}";

        Console.WriteLine("Your new job title: " + jobTitle);
    }
}