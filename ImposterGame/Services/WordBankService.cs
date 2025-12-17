namespace ImposterGame.Services;

public class WordBankService
{
    private readonly Dictionary<string, List<string>> _wordBanks = new()
    {
        ["Technology"] = new()
        {
            "Algorithm", "Blockchain", "Cloud", "Database", "Encryption", "Firewall", "Gateway", "Hardware",
            "Interface", "JavaScript", "Kubernetes", "Linux", "Microservice", "Network", "Operating System",
            "Protocol", "Query", "Router", "Server", "Terminal", "URL", "Virtual Machine", "Wireless",
            "XML", "Compiler", "API", "Framework", "Repository", "Cache", "Docker", "Azure", "Python",
            "React", "Angular", "TypeScript", "HTML", "CSS", "SQL", "NoSQL", "Git", "GitHub", "DevOps",
            "Agile", "Sprint", "Scrum", "CI/CD", "Deployment", "Container", "GraphQL", "Terraform",
            "Jenkins", "Redis", "MongoDB"
        },
        ["Animals"] = new()
        {
            "Lion", "Tiger", "Bear", "Elephant", "Giraffe", "Zebra", "Monkey", "Gorilla", "Chimpanzee",
            "Orangutan", "Kangaroo", "Koala", "Panda", "Penguin", "Dolphin", "Whale", "Shark", "Octopus",
            "Eagle", "Hawk", "Owl", "Parrot", "Peacock", "Flamingo", "Swan", "Duck", "Goose", "Turkey",
            "Chicken", "Rooster", "Pig", "Cow", "Horse", "Sheep", "Goat", "Dog", "Cat", "Rabbit",
            "Hamster", "Guinea Pig", "Mouse", "Rat", "Squirrel", "Chipmunk", "Beaver", "Otter", "Seal",
            "Walrus", "Polar Bear", "Grizzly Bear", "Wolf", "Fox", "Deer", "Moose", "Elk"
        },
        ["People"] = new()
        {
            "Teacher", "Doctor", "Nurse", "Engineer", "Architect", "Artist", "Musician", "Actor", "Director",
            "Writer", "Journalist", "Lawyer", "Judge", "Police Officer", "Firefighter", "Pilot", "Astronaut",
            "Scientist", "Researcher", "Professor", "Chef", "Baker", "Waiter", "Bartender", "Farmer",
            "Carpenter", "Electrician", "Plumber", "Mechanic", "Driver", "Athlete", "Coach", "Referee",
            "Photographer", "Designer", "Developer", "Manager", "Accountant", "Banker", "Salesperson",
            "Consultant", "Entrepreneur", "CEO", "President", "Mayor", "Governor", "Senator", "Congressman",
            "Diplomat", "Soldier", "Sailor", "Marine", "Librarian", "Dentist", "Veterinarian"
        },
        ["Sports"] = new()
        {
            "Football", "Basketball", "Baseball", "Soccer", "Tennis", "Golf", "Hockey", "Cricket",
            "Rugby", "Volleyball", "Badminton", "Table Tennis", "Swimming", "Diving", "Gymnastics",
            "Track and Field", "Marathon", "Boxing", "Wrestling", "Judo", "Karate", "Taekwondo",
            "Fencing", "Archery", "Shooting", "Cycling", "Mountain Biking", "Skateboarding", "Surfing",
            "Skiing", "Snowboarding", "Ice Skating", "Figure Skating", "Bobsled", "Luge", "Curling",
            "Bowling", "Darts", "Billiards", "Snooker", "Chess", "Poker", "Bridge", "Lacrosse",
            "Softball", "Ultimate Frisbee", "Racquetball", "Squash", "Handball", "Water Polo", "Rowing",
            "Sailing", "Kayaking", "Rock Climbing", "Triathlon"
        },
        ["Old Testament"] = new()
        {
            "Adam", "Eve", "Noah", "Abraham", "Isaac", "Jacob", "Joseph", "Moses", "Aaron", "Joshua",
            "Caleb", "Gideon", "Samson", "Samuel", "Saul", "David", "Solomon", "Elijah", "Elisha",
            "Isaiah", "Jeremiah", "Ezekiel", "Daniel", "Hosea", "Joel", "Amos", "Obadiah", "Jonah",
            "Micah", "Nahum", "Habakkuk", "Zephaniah", "Haggai", "Zechariah", "Malachi", "Ruth",
            "Esther", "Job", "Sarah", "Rebecca", "Rachel", "Leah", "Miriam", "Deborah", "Hannah",
            "Bathsheba", "Goliath", "Pharaoh", "Nebuchadnezzar", "Cyrus", "Ezra", "Nehemiah", "Mordecai",
            "Haman", "Boaz", "Jesse"
        },
        ["New Testament"] = new()
        {
            "Matthew", "Mark", "Luke", "John", "Peter", "Andrew", "James", "Philip", "Bartholomew",
            "Thomas", "Judas Iscariot", "Simon", "Thaddaeus", "Paul", "Barnabas", "Timothy", "Titus",
            "Silas", "Mary", "Martha", "Lazarus", "Mary Magdalene", "Nicodemus", "Joseph of Arimathea",
            "Zacchaeus", "Pontius Pilate", "Herod", "Caiaphas", "Annas", "John the Baptist", "Elizabeth",
            "Zechariah", "Simeon", "Anna", "Stephen", "Philip the Evangelist", "Priscilla", "Aquila",
            "Apollos", "Lydia", "Dorcas", "Cornelius", "Agabus", "James (brother of Jesus)", "Jude",
            "Onesimus", "Philemon", "Phoebe", "Epaphroditus", "Euodia", "Syntyche", "Clement", "Demas",
            "Gaius", "Diotrephes"
        },
        ["Jesus"] = new()
        {
            "Sermon on the Mount", "Beatitudes", "Lord's Prayer", "Transfiguration", "Crucifixion",
            "Resurrection", "Ascension", "Baptism", "Temptation", "Feeding of 5000", "Walking on Water",
            "Calming the Storm", "Wedding at Cana", "Raising Lazarus", "Healing the Blind", "Healing the Lame",
            "Cleansing the Temple", "Last Supper", "Garden of Gethsemane", "Trial", "Crown of Thorns",
            "Good Shepherd", "Light of the World", "Bread of Life", "Living Water", "True Vine",
            "Way Truth Life", "Alpha and Omega", "King of Kings", "Prince of Peace", "Emmanuel",
            "Lamb of God", "Son of God", "Son of Man", "Messiah", "Christ", "Savior", "Redeemer",
            "Advocate", "Mediator", "High Priest", "Prophet", "Teacher", "Rabbi", "Master", "Lord",
            "Parable of the Sower", "Prodigal Son", "Good Samaritan", "Lost Sheep", "Mustard Seed",
            "Great Commission", "Miracles", "Parables", "Teachings", "Compassion"
        },
        ["The Flood"] = new()
        {
            "Noah", "Ark", "Rainbow", "Covenant", "Dove", "Raven", "Olive Branch", "Mount Ararat",
            "Forty Days", "Forty Nights", "Rain", "Floodwaters", "Wickedness", "Righteous", "Generations",
            "Shem", "Ham", "Japheth", "Gopherwood", "Pitch", "Three Stories", "Window", "Door",
            "Cubit", "Pairs of Animals", "Clean Animals", "Unclean Animals", "Seven Pairs", "Male and Female",
            "Waters Prevailed", "Mountains Covered", "All Flesh", "Breath of Life", "Waters Receded",
            "Earth Dried", "Altar", "Sacrifice", "Pleasing Aroma", "Never Again", "Seasons", "Seedtime",
            "Harvest", "Sign of Covenant", "Clouds", "Nephilim", "Giants", "Corruption", "Violence",
            "Days of Noah", "God Remembered", "Window Opened", "Fountains of the Deep", "Windows of Heaven",
            "One Hundred Twenty Years", "Sons of God"
        },
        ["Revelation"] = new()
        {
            "John", "Patmos", "Seven Churches", "Ephesus", "Smyrna", "Pergamum", "Thyatira", "Sardis",
            "Philadelphia", "Laodicea", "Alpha and Omega", "Throne Room", "Twenty-Four Elders", "Four Living Creatures",
            "Seven Seals", "Seven Trumpets", "Seven Bowls", "Lamb", "Book of Life", "New Jerusalem",
            "White Horse", "Red Horse", "Black Horse", "Pale Horse", "Martyrs", "Earthquake", "Sun Darkened",
            "Moon Blood", "Stars Fell", "Scroll", "Angel", "Two Witnesses", "Beast", "Dragon", "False Prophet",
            "Mark of the Beast", "666", "Babylon", "Great Harlot", "Armageddon", "Thousand Years", "Lake of Fire",
            "Second Death", "Tree of Life", "River of Life", "No More Tears", "No More Death", "New Heaven",
            "New Earth", "Holy City", "Pearly Gates", "Streets of Gold", "Jasper", "Crystal", "Glory of God",
            "Marriage Supper", "Bride of Christ"
        },
        ["Broadway Musicals"] = new()
        {
            "Hamilton", "Alexander Hamilton", "Burr", "Eliza", "Angelica", "My Shot", "Ten Duel Commandments",
            "Phantom of the Opera", "Christine", "Raoul", "Music of the Night", "Masquerade", "Chandelier",
            "Lion King", "Simba", "Nala", "Mufasa", "Scar", "Circle of Life", "Hakuna Matata",
            "Wicked", "Elphaba", "Glinda", "Defying Gravity", "Popular", "Emerald City", "Flying Monkeys",
            "Les Misérables", "Jean Valjean", "Javert", "Cosette", "Marius", "Eponine", "One Day More", "I Dreamed a Dream",
            "Chicago", "Roxie Hart", "Velma Kelly", "Billy Flynn", "Cell Block Tango", "All That Jazz", "Razzle Dazzle",
            "Cats", "Grizabella", "Memory", "Jellicle Cats", "Mr. Mistoffelees", "Rum Tum Tugger",
            "West Side Story", "Maria", "Tony", "Bernardo", "Tonight", "America", "Somewhere", "Jets", "Sharks",
            "Sound of Music", "Maria von Trapp", "Captain", "Do-Re-Mi", "Edelweiss", "My Favorite Things", "Climb Every Mountain",
            "Fiddler on the Roof", "Tevye", "Golde", "Sunrise Sunset", "If I Were a Rich Man", "Matchmaker", "Tradition",
            "My Fair Lady", "Eliza Doolittle", "Henry Higgins", "The Rain in Spain", "I Could Have Danced All Night",
            "Rent", "Mimi", "Roger", "Mark", "Angel", "Seasons of Love", "La Vie Bohème", "No Day But Today",
            "A Chorus Line", "What I Did for Love", "One", "Dance Ten Looks Three", "I Hope I Get It",
            "Avenue Q", "Princeton", "Kate Monster", "Purpose", "Everyone's a Little Bit Racist", "For Now",
            "Dear Evan Hansen", "Evan Hansen", "Waving Through a Window", "You Will Be Found", "Sincerely Me",
            "Come From Away", "Gander", "Newfoundland", "Welcome to the Rock", "Me and the Sky",
            "Book of Mormon", "Elder Price", "Elder Cunningham", "Hello", "I Believe", "Turn It Off",
            "Mamma Mia", "Dancing Queen", "ABBA", "Take a Chance on Me", "The Winner Takes It All",
            "Jersey Boys", "Frankie Valli", "Four Seasons", "Sherry", "Big Girls Don't Cry", "Can't Take My Eyes Off You",
            "Kinky Boots", "Charlie Price", "Lola", "Raise You Up", "Sex Is in the Heel", "Land of Lola"
        },
        ["Broadway Musical Shows"] = new()
        {
            "Hamilton", "Wicked", "The Phantom of the Opera", "The Lion King", "Les Misérables", "Chicago",
            "Cats", "West Side Story", "The Sound of Music", "Fiddler on the Roof", "My Fair Lady", "Rent",
            "A Chorus Line", "Avenue Q", "Dear Evan Hansen", "Come From Away", "The Book of Mormon",
            "Mamma Mia!", "Jersey Boys", "Kinky Boots", "Hairspray", "The Producers", "Grease", "Annie",
            "Oklahoma!", "South Pacific", "The King and I", "Guys and Dolls", "Cabaret", "Sweeney Todd",
            "Into the Woods", "Sunday in the Park with George", "Company", "Follies", "A Little Night Music",
            "Evita", "Jesus Christ Superstar", "Joseph and the Amazing Technicolor Dreamcoat", "Pippin",
            "Godspell", "Hair", "The Rocky Horror Show", "Little Shop of Horrors", "Spring Awakening",
            "Next to Normal", "Fun Home", "Hadestown", "Waitress", "Frozen", "Aladdin", "The Little Mermaid",
            "Beauty and the Beast", "Newsies", "Matilda", "School of Rock", "Beetlejuice", "Mean Girls",
            "Moulin Rouge!", "Six", "& Juliet"
        }
    };

    public List<string> GetThemes()
    {
        return _wordBanks.Keys.OrderBy(k => k).ToList();
    }

    public string GetRandomWord(string theme)
    {
        if (!_wordBanks.ContainsKey(theme))
        {
            throw new ArgumentException($"Theme '{theme}' not found");
        }

        var words = _wordBanks[theme];
        var random = new Random();
        return words[random.Next(words.Count)];
    }
}
