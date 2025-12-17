using ImposterGame.Models;

namespace ImposterGame.Services;

public class QuizService
{
    private readonly Dictionary<string, List<QuizQuestion>> _quizzes = new()
    {
        ["General Knowledge"] = new()
        {
            new QuizQuestion
            {
                Question = "What is the capital of France?",
                Answers = new List<string> { "London", "Berlin", "Paris", "Madrid" },
                CorrectAnswerIndex = 2,
                Category = "Geography"
            },
            new QuizQuestion
            {
                Question = "Which planet is known as the Red Planet?",
                Answers = new List<string> { "Venus", "Mars", "Jupiter", "Saturn" },
                CorrectAnswerIndex = 1,
                Category = "Science"
            },
            new QuizQuestion
            {
                Question = "Who painted the Mona Lisa?",
                Answers = new List<string> { "Vincent van Gogh", "Pablo Picasso", "Leonardo da Vinci", "Michelangelo" },
                CorrectAnswerIndex = 2,
                Category = "Art"
            },
            new QuizQuestion
            {
                Question = "What is the largest ocean on Earth?",
                Answers = new List<string> { "Atlantic Ocean", "Indian Ocean", "Arctic Ocean", "Pacific Ocean" },
                CorrectAnswerIndex = 3,
                Category = "Geography"
            },
            new QuizQuestion
            {
                Question = "In which year did World War II end?",
                Answers = new List<string> { "1943", "1944", "1945", "1946" },
                CorrectAnswerIndex = 2,
                Category = "History"
            },
            new QuizQuestion
            {
                Question = "What is the smallest country in the world?",
                Answers = new List<string> { "Monaco", "Vatican City", "San Marino", "Liechtenstein" },
                CorrectAnswerIndex = 1,
                Category = "Geography"
            },
            new QuizQuestion
            {
                Question = "Which element has the chemical symbol 'O'?",
                Answers = new List<string> { "Gold", "Oxygen", "Osmium", "Oganesson" },
                CorrectAnswerIndex = 1,
                Category = "Science"
            },
            new QuizQuestion
            {
                Question = "How many continents are there?",
                Answers = new List<string> { "5", "6", "7", "8" },
                CorrectAnswerIndex = 2,
                Category = "Geography"
            },
            new QuizQuestion
            {
                Question = "What is the tallest mountain in the world?",
                Answers = new List<string> { "K2", "Mount Everest", "Kilimanjaro", "Denali" },
                CorrectAnswerIndex = 1,
                Category = "Geography"
            },
            new QuizQuestion
            {
                Question = "Which programming language is used for web development?",
                Answers = new List<string> { "Python", "C++", "JavaScript", "Swift" },
                CorrectAnswerIndex = 2,
                Category = "Technology"
            }
        },
        ["Science"] = new()
        {
            new QuizQuestion
            {
                Question = "What is the speed of light?",
                Answers = new List<string> { "300,000 km/s", "150,000 km/s", "450,000 km/s", "200,000 km/s" },
                CorrectAnswerIndex = 0,
                Category = "Physics"
            },
            new QuizQuestion
            {
                Question = "What is the chemical formula for water?",
                Answers = new List<string> { "CO2", "H2O", "O2", "NaCl" },
                CorrectAnswerIndex = 1,
                Category = "Chemistry"
            },
            new QuizQuestion
            {
                Question = "What is the powerhouse of the cell?",
                Answers = new List<string> { "Nucleus", "Ribosome", "Mitochondria", "Chloroplast" },
                CorrectAnswerIndex = 2,
                Category = "Biology"
            },
            new QuizQuestion
            {
                Question = "How many bones are in the human body?",
                Answers = new List<string> { "186", "206", "226", "246" },
                CorrectAnswerIndex = 1,
                Category = "Biology"
            },
            new QuizQuestion
            {
                Question = "What is the largest organ in the human body?",
                Answers = new List<string> { "Heart", "Brain", "Liver", "Skin" },
                CorrectAnswerIndex = 3,
                Category = "Biology"
            },
            new QuizQuestion
            {
                Question = "What gas do plants absorb from the atmosphere?",
                Answers = new List<string> { "Oxygen", "Nitrogen", "Carbon Dioxide", "Hydrogen" },
                CorrectAnswerIndex = 2,
                Category = "Biology"
            },
            new QuizQuestion
            {
                Question = "What is the boiling point of water at sea level?",
                Answers = new List<string> { "90°C", "100°C", "110°C", "120°C" },
                CorrectAnswerIndex = 1,
                Category = "Chemistry"
            },
            new QuizQuestion
            {
                Question = "What force keeps us on the ground?",
                Answers = new List<string> { "Magnetism", "Gravity", "Friction", "Inertia" },
                CorrectAnswerIndex = 1,
                Category = "Physics"
            },
            new QuizQuestion
            {
                Question = "What is the center of an atom called?",
                Answers = new List<string> { "Electron", "Proton", "Neutron", "Nucleus" },
                CorrectAnswerIndex = 3,
                Category = "Chemistry"
            },
            new QuizQuestion
            {
                Question = "How many planets are in our solar system?",
                Answers = new List<string> { "7", "8", "9", "10" },
                CorrectAnswerIndex = 1,
                Category = "Astronomy"
            }
        },
        ["History"] = new()
        {
            new QuizQuestion
            {
                Question = "Who was the first president of the United States?",
                Answers = new List<string> { "Thomas Jefferson", "George Washington", "John Adams", "Benjamin Franklin" },
                CorrectAnswerIndex = 1,
                Category = "American History"
            },
            new QuizQuestion
            {
                Question = "In which year did Christopher Columbus discover America?",
                Answers = new List<string> { "1492", "1498", "1502", "1488" },
                CorrectAnswerIndex = 0,
                Category = "World History"
            },
            new QuizQuestion
            {
                Question = "Who was the ancient Greek god of war?",
                Answers = new List<string> { "Zeus", "Apollo", "Ares", "Poseidon" },
                CorrectAnswerIndex = 2,
                Category = "Ancient History"
            },
            new QuizQuestion
            {
                Question = "What year did the Berlin Wall fall?",
                Answers = new List<string> { "1987", "1988", "1989", "1990" },
                CorrectAnswerIndex = 2,
                Category = "Modern History"
            },
            new QuizQuestion
            {
                Question = "Who was the first person to walk on the moon?",
                Answers = new List<string> { "Buzz Aldrin", "Neil Armstrong", "Yuri Gagarin", "John Glenn" },
                CorrectAnswerIndex = 1,
                Category = "Space History"
            },
            new QuizQuestion
            {
                Question = "Which ancient wonder of the world still exists?",
                Answers = new List<string> { "Colossus of Rhodes", "Hanging Gardens", "Great Pyramid of Giza", "Temple of Artemis" },
                CorrectAnswerIndex = 2,
                Category = "Ancient History"
            },
            new QuizQuestion
            {
                Question = "Who wrote the Declaration of Independence?",
                Answers = new List<string> { "George Washington", "Benjamin Franklin", "Thomas Jefferson", "John Adams" },
                CorrectAnswerIndex = 2,
                Category = "American History"
            },
            new QuizQuestion
            {
                Question = "What was the name of the ship that brought the Pilgrims to America?",
                Answers = new List<string> { "Santa Maria", "Mayflower", "Nina", "Pinta" },
                CorrectAnswerIndex = 1,
                Category = "American History"
            },
            new QuizQuestion
            {
                Question = "Which empire built Machu Picchu?",
                Answers = new List<string> { "Aztec", "Maya", "Inca", "Olmec" },
                CorrectAnswerIndex = 2,
                Category = "Ancient History"
            },
            new QuizQuestion
            {
                Question = "In which year did the Titanic sink?",
                Answers = new List<string> { "1910", "1911", "1912", "1913" },
                CorrectAnswerIndex = 2,
                Category = "Modern History"
            }
        },
        ["Technology"] = new()
        {
            new QuizQuestion
            {
                Question = "Who is the founder of Microsoft?",
                Answers = new List<string> { "Steve Jobs", "Bill Gates", "Mark Zuckerberg", "Elon Musk" },
                CorrectAnswerIndex = 1,
                Category = "Tech History"
            },
            new QuizQuestion
            {
                Question = "What does 'HTTP' stand for?",
                Answers = new List<string> { "HyperText Transfer Protocol", "High Transfer Text Protocol", "HyperText Translation Protocol", "Home Tool Transfer Protocol" },
                CorrectAnswerIndex = 0,
                Category = "Internet"
            },
            new QuizQuestion
            {
                Question = "Which company developed the iPhone?",
                Answers = new List<string> { "Samsung", "Google", "Apple", "Microsoft" },
                CorrectAnswerIndex = 2,
                Category = "Mobile"
            },
            new QuizQuestion
            {
                Question = "What does 'AI' stand for?",
                Answers = new List<string> { "Automated Intelligence", "Artificial Intelligence", "Advanced Information", "Automatic Integration" },
                CorrectAnswerIndex = 1,
                Category = "Computing"
            },
            new QuizQuestion
            {
                Question = "What year was Google founded?",
                Answers = new List<string> { "1996", "1998", "2000", "2002" },
                CorrectAnswerIndex = 1,
                Category = "Tech History"
            },
            new QuizQuestion
            {
                Question = "What does 'CPU' stand for?",
                Answers = new List<string> { "Computer Processing Unit", "Central Processing Unit", "Central Program Utility", "Computer Program Unit" },
                CorrectAnswerIndex = 1,
                Category = "Hardware"
            },
            new QuizQuestion
            {
                Question = "Which programming language is known for its use in web development alongside HTML and CSS?",
                Answers = new List<string> { "Python", "Java", "JavaScript", "C++" },
                CorrectAnswerIndex = 2,
                Category = "Programming"
            },
            new QuizQuestion
            {
                Question = "What does 'VR' stand for?",
                Answers = new List<string> { "Virtual Reality", "Visual Reality", "Video Reality", "Variable Reality" },
                CorrectAnswerIndex = 0,
                Category = "Emerging Tech"
            },
            new QuizQuestion
            {
                Question = "Which social media platform has a bird as its logo?",
                Answers = new List<string> { "Facebook", "Instagram", "Twitter/X", "LinkedIn" },
                CorrectAnswerIndex = 2,
                Category = "Social Media"
            },
            new QuizQuestion
            {
                Question = "What is the maximum speed of USB 3.0?",
                Answers = new List<string> { "480 Mbps", "5 Gbps", "10 Gbps", "20 Gbps" },
                CorrectAnswerIndex = 1,
                Category = "Hardware"
            }
        }
    };

    public List<string> GetCategories()
    {
        return _quizzes.Keys.OrderBy(k => k).ToList();
    }

    public List<QuizQuestion> GetQuiz(string category, int questionCount = 5)
    {
        if (!_quizzes.ContainsKey(category))
        {
            throw new ArgumentException($"Category '{category}' not found");
        }

        var allQuestions = _quizzes[category];
        
        // Shuffle and take the requested number of questions
        return allQuestions
            .OrderBy(x => Random.Shared.Next())
            .Take(Math.Min(questionCount, allQuestions.Count))
            .ToList();
    }

    public int CalculateScore(int timeRemaining, int maxTime, bool isCorrect)
    {
        if (!isCorrect) return 0;
        
        // Base points for correct answer
        int basePoints = 500;
        
        // Bonus points based on speed (up to 500 points)
        int speedBonus = (int)((timeRemaining / (double)maxTime) * 500);
        
        return basePoints + speedBonus;
    }
}
