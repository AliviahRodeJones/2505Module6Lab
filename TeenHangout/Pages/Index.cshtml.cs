using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TeenHangout.Pages;

public class IndexModel : PageModel
{
    // Array of users. Creates 5 new instances of the class User and stores them in an array. 
    public User[] Users { get; } =
    [
        // Module 6 Lab Users.
        new("MusicLover", 15, "Purple"),
        new("GamerGirl", 16, "Red"),
        new("BookwormBen", 15, "Yellow"),

        // Module 6 Coding Challenge Users
        new("PokemonFan", 15, "Orange"), // New user 
        new("MarathonFanMichael", 17, "Green") // New user
    ];

    
    public Post[] Posts { get; } =
    [
        // Module 6 Lab Posts.
        new("GamerGirl", "Anyone want to play online later?", 30),
        new("BookwormBen", "Reading the best book ever!", 15),
        new("MusicLover", "Concert next week! So excited!", 22), 

        // Module 6 Coding Challenge Posts.
        new("MarathonFanMichael", "Attending a 10k this weekend! Wish me luck!", 20), //new post
        new("PokemonFan", "Just caught a shiny Gyrados! So awesome!", 19) // new post
    ];
    // Array of posts. Creates 5 new instances of the Class Post and stores them in an array.

    // Counts the total likes value for the site. 
    
    public static int likeCounter { get; set ;}
    

}