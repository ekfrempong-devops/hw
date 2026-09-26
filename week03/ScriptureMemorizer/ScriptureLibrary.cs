// This code allows the program to work with a library of scriptures rather than a single one.
// Scripture is chosen at random and presented tro the user.

public class ScriptureLibrary
{
    private List<Scripture> _scriptures;

    public ScriptureLibrary()
    {
        _scriptures = new List<Scripture>();

        Reference johnReference = new Reference("John", 3, 16);

        string johnText = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";

        Scripture john = new Scripture(johnReference, johnText);

        _scriptures.Add(john);


        Reference proverbsReference = new Reference("Proverbs", 3, 5, 6);

        string proverbsText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

        Scripture proverbs = new Scripture(proverbsReference, proverbsText);

        _scriptures.Add(proverbs);
    }

    public Scripture GetRandomScripture()
{
    Random random = new Random();

    int index = random.Next(_scriptures.Count);

    return _scriptures[index];
}
}