string[] adjectives = { "Senior", "Lead", "Dynamic", "Unpaid", "Future", "Virtual" };
string[] roles = { "Data Wrangler", "Pixel Architect", "Spreadsheet Ninja", "Cloud Whisperer", "Tech Wizard" }; 

Random rand = new Random(); 
string adjective = adjectives[rand.Next(adjectives.Length)];
string role = roles[rand.Next(roles.Length)]; 

string jobTitle = $"{adjective} {role}"