namespace ImposterGame.Models;

public class QuizQuestion
{
    public string Question { get; set; } = string.Empty;
    public List<string> Answers { get; set; } = new();
    public int CorrectAnswerIndex { get; set; }
    public string? Category { get; set; }
    public int TimeLimit { get; set; } = 20; // seconds
}
