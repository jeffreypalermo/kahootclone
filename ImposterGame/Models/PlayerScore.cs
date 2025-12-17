namespace ImposterGame.Models;

public class PlayerScore
{
    public string PlayerName { get; set; } = string.Empty;
    public int TotalScore { get; set; }
    public int CorrectAnswers { get; set; }
    public int AnswerStreak { get; set; }
}
