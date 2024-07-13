using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Video _video1 = new Video("[Vocaloid] Snowman MMD + UTAU COVER! Feat. Yuri SAIS", "BOOM! Fanfic-a-latta!", "3:49");
        _video1.AddComment("Mr. L Productions", "Merry Christmas. Best wishes");
        _video1.AddComment("Arti Does Things", "Merry crimbus!!! Happy holidays!! :D");
        _video1.AddComment("BlueFoxy87", "Can you do toads factory with lyrics? From Mario kart Wii?");
        _video1.AddComment("TheChocoChicken", "HAPPY IT IS DEFINITELY STILL CHRISTMAS AND I AM NOT LATE AT ALL! First, I like the SwSh Trainer model you made there. Usually light blue and dark green don't work great together, but you really made it work! Or maybe it's actually silver and that's just the lighting oops.  As for the Yuri singing, I like it! It retains your voice while having that Vocaloid style very well, and mostly everything is clear except for a couple syllables.  I like the design you have for the general area, with the snow and stone being painted a warmer hue by all the lights, from the lit-up homes to the candles and all. Though from a distance it does look a bit like cheese. Or maybe I'm just hungry, very likely and very possible Anyway merry new year, I am not late yet!");

        _videos.Add(_video1);

        Video _video2 = new Video("LET'S PLAY: The Stanley Parable Demonstration!!!", "BOOM! Fanfic-a-latta!", "31:15");
        _video2.AddComment("J2TheT", "ok wow! I've never heard of the Stanley Parable demo, but this is so meta. If your up for suggestions for games to play, the Antonblast Demo is the bomb!");
        _video2.AddComment("Sky Queen", "Yay, Stanley Parable Demo!! Thank you for doing this, Lily!");
        _video2.AddComment("Thefunnyguy", "HOLY MOLY P!!!");

        _videos.Add(_video2);

        Video _video3 = new Video("[Kirby and the Forgotten Land] Running Through the New World WITH LYRICS! (Kirby 30th Anniversary!)", "BOOM! Fanfic-a-latta!", "2:29");
        _video3.AddComment("TheChocoChicken", "Your voice makes me imagine this from the perspective of Bandanna Waddle Dee, and that context only made this song all the sweeter. I adore the vibe the lyrics gave it - that celebratory adrenaline rush of 'NEW KIRBY GAME IS OUT' that I certainly did feel every time I heard news about this game! In particular I just want to bright out that line 'Buildings old and lost to earth and time/Towers standing tall and ready to climb' - that transition from the unsettling near liminal space to the childlike joy and fun that Kirby can see in it really captures the essence of this song, and this game. Absolute delight of a cover! Keep it up, Mint!");
        _video3.AddComment("Multifandom Fangirl", "I have finally played this game and I love how you match the lyrics with the music it's perfect!");
        _video3.AddComment("Toxic J", "Poyo poyo, poyo poyo poyo. POYO!!");

        _videos.Add(_video3);

        Video _video4 = new Video("[Mario Kart Wii/8 Deluxe Booster Pack] Coconut Mall WITH LYRICS!!! (APRIL FOOLS!)", "BOOM! Fanfic-a-latta!", "1:18");
        _video4.AddComment("RGL2024", "Oh crap, here we go again");
        _video4.AddComment("SuperLuigiBran", "As I suspected coconut mall");
        _video4.AddComment("Caine Begay", "Wellcome to coconut mall");
        _video4.AddComment("TheChocoChicken", "Can't believe you've done this. I am Coconut Falling out of my chair. Also this is good. I like the effects that make this an ad but like actually good. And your voice on the high notes was real smooth! Nice job. Coconut mall");

        _videos.Add(_video4);

        foreach (Video _video in _videos)
        {
            Console.WriteLine($"\n \n \n {_video.ReturnVideo()}");
        }
    }
}