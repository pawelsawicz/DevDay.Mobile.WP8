using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevDay.Mobile.WP8.Data.Agenda
{
    public class ListOfLectures
    {
        public List<Lecture> Lectures { get; set; }

        public ListOfLectures()
        {
            Lectures = new List<Lecture>();
        }
    }

    public class CoffeBreak : Lecture
    {
        public CoffeBreak()
        {
            Name = "Coffee!";
            Classroom = "/Assets/Images/neutral_path.png";
            Category = "Neutral";
        }
    }

    public class Registration : Lecture
    {
        public Registration()
        {
            Name = "Registration";
            Time = "8:00 - 9:00";
            Classroom = "/Assets/Images/neutral_path.png";
            Category = "Neutral";
        }
    }

    public class Welcome : Lecture
    {
        public Welcome()
        {
            Name = "Welcome session";
            Time = "9:00 - 9:20";
            Classroom = "/Assets/Images/neutral_path.png";
            Category = "Neutral";
        }
    }

    public class First : Lecture
    {
        public First()
        {
            IdLecture = 1;
            Name = "Software Architecture vs Code";
            Time = "9:20 - 10:10";
            NameOfPresenter = "Simon Brown";
            Classroom = "/Assets/Images/neutral_path.png";
            VoteURL = "/Assets/Images/Vote/blue_tick.png";
            Category = "Neutral";
            Description = "Software architecture and coding are often seen as mutually exclusive disciplines, despite us referring to higher level abstractions when we talk about our software." +
                "You've probably heard others on your team talking about components, services and layers rather than objects when they're having discussions. Take a look at the codebase though." +
                "Can you clearly see these abstractions or does the code reflect some other structure? If so, why is there no clear mapping between the architecture and the code? " +
                "Why do those architecture diagrams that you have on the wall say one thing whereas your code says another? " +
                "In fact, why is it so hard to automatically generate a decent architecture diagram from an existing codebase? " +
                "Join us to explore this topic further.";
        }
    }

    public class SecondGreen : Lecture
    {
        public SecondGreen()
        {
            IdLecture = 2;
            Name = "Defensive Programming 101 v5 - Common Security Mistakes in Web Applications";
            Time = "10:40 - 11:30";
            NameOfPresenter = "Niall Merrigan";
            Classroom = "/Assets/Images/green_path.png";
            VoteURL = "/Assets/Images/Vote/blue_tick.png";
            Category = "Green";
            Description = "The web is a funny old place. You create a wonderful application, deploy it for the world to see and then everybody just wants to break it. " +
                "This session will show you some of the common security mistakes made by developers and how to avoid them. " +
                "There will be (possibly frightening) demos with code in C#. Talk is rated level 200-300 with a target audience of " +
                "web developers (not just ASP.NET. All the examples will be done in .NET. Even if you are not a web developer some of the parts of the talk will be handy) " +
                "and assumes knowledge of web programming, basic security concepts, a working brain and sense of humour.";
        }
    }

    public class SecondBlue : Lecture
    {
        public SecondBlue()
        {
            IdLecture = 3;
            Name = "Why No Code Reviews?";
            Time = "10:40 - 11:30";
            NameOfPresenter = "Enrico Campidoglio";
            Classroom = "/Assets/Images/blue_path.png";
            VoteURL = "/Assets/Images/Vote/blue_tick.png";
            Description = "It’s undisputed that regular peer reviews are one of the most effective ways to maintain high quality in a code base. " +
                "Yet, so many development teams choose not to adopt them for their software project. In the publishing industry, no written word ever sees " +
                "the light of day before it has gone through an extensive period of critical review. This applies to books, scientific papers and newspaper " +
                "articles alike. Why not software? " +
                "In this session we’ll explore the social and practical reasons why code reviews aren’t as widely adopted in modern software development shops as " +
                "they should be. We’ll also look at a few concrete tools and techniques that teams can put in place to help them overcome the most common road blocks. " +
                "In the end, we’ll see how code reviews help peers leverage each other’s knowledge and skills to ensure their work is as good as it can possibly be.";
            Category = "Blue";
        }
    }

    public class ThirdGreen : Lecture
    {
        public ThirdGreen()
        {
            IdLecture = 4;
            Name = "So Long, and Thanks for All the Tests";
            Time = "11:50 - 12:40";
            NameOfPresenter = "Seb Rose";
            Classroom = "/Assets/Images/green_path.png";
            VoteURL = "/Assets/Images/Vote/blue_tick.png";
            Category = "Green";
            Description = "TDD has long been recommended by agile practitioners, but the community still argues about how to go about it. " +
                "Inside-out or outside-in? Mockist or classical? Through a component's public API or for every class? And then there's Kent Beck's famous quote: " +
                "“I get paid for code that works, not for tests, so my philosophy is to test as little as possible to reach a given level of confidence.” " +
                "This introduces a further level of subjectivity, especially since developers are frequently overconfident. " +
                "In this session, Seb will explore the choices that agile teams need to make when considering which development practices to adopt. " +
                "He'll look again at some of the arguments for the different approaches and urge teams to practice until you're happy with the way you code.";
        }
    }

    public class ThirdBlue : Lecture
    {
        public ThirdBlue()
        {
            IdLecture = 7;
            Name = "Hacking the Mind: How Art Can Help Us Talk (and Teach) Technology";
            Time = "11:50 - 12:40";
            NameOfPresenter = "Qi";
            Classroom = "/Assets/Images/blue_path.png";
            VoteURL = "/Assets/Images/Vote/blue_tick.png";
            Description = "The world of software development is changing at an increasingly rapid pace, leaving developers with less time to learn new tools and paradigms, " +
                "and hardly any time to convey that knowledge to others. How do we convince our managers to change course? How do we bring other " +
                "developers up to speed? And if things go wrong, how do we explain it to our non-technical customers without losing their trust? " +
                "Qi will talk about the relationship between art and code, and how we can use the principles of fiction, music, poetry and painting to present complex " +
                "information to any audience without confusing or -- worse -- boring them to tears.";
            Category = "Blue";
        }
    }

    public class Lunch : Lecture
    {
        public Lunch()
        {
            Name = "Lunch";
            Time = "12:40 - 13:50";
            Classroom = "/Assets/Images/neutral_path.png";
            Category = "Neutral";
        }
    }
}
