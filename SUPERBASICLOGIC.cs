public class Bot
{
    public float Health { get; set; }
    public float MaxHealth { get; set; }
    public bool? IsAlive { get; set; }
    public int? IsUncon { get; set; }

    public Bot()
    {
        Health = 100;
        MaxHealth = 100;
        IsAlive = true;
        IsUncon = null;
    }

    public void TakeDamage(float damage)
    {
        Health -= damage;

        if (Health <= 0)
        {
            Health = 0;
            IsAlive = true; // Bot is technically "alive"
            IsUncon = -1; // Bot is "unconscious"
            MaxHealth = 0; // Bot's max health is 0
            PlaySound("uncondeath.wav"); // Play the "uncondeath.wav" sound
        }
    }

    public void PlayerAttack()
    {
        Health = 0; // Player's damage always sets the bot's health to 0
    }

    private void PlaySound(string soundFile)
    {
        // Implement the logic to play the sound file here
    }
}
