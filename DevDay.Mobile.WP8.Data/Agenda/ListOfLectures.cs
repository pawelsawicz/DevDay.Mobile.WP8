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
            Lectures.Add(new Registration());
            Lectures.Add(new Welcome());
            Lectures.Add(new First());
            Lectures.Add(new CoffeBreak() { Time = "10:10 - 10:40" });
            Lectures.Add(new SecondGreen());
            Lectures.Add(new SecondBlue());
            Lectures.Add(new CoffeBreak() { Time = "11:30 - 11:50" });
            Lectures.Add(new ThirdGreen());
            Lectures.Add(new ThirdBlue());
            Lectures.Add(new Lunch());
            Lectures.Add(new FourthGreen());
            Lectures.Add(new FourthBlue());
            Lectures.Add(new CoffeBreak() { Time = "14:40 - 15:00" });
            Lectures.Add(new FifthGreen());
            Lectures.Add(new FifthBlue());
            Lectures.Add(new CoffeBreak() { Time = "15:50 - 16:10" });
            Lectures.Add(new SixthGreen());
            Lectures.Add(new SixthBlue());
            Lectures.Add(new CoffeBreak() { Time = "17:00 - 17:30" });
            Lectures.Add(new Seventh());
            Lectures.Add(new Party());

            foreach (var item in Lectures)
            {
                //item.SetTime();
                //item.CheckVoting();
            }
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

    public class FourthGreen : Lecture
    {
        public FourthGreen()
        {
            IdLecture = 6;
            Name = "React + NPM for Great Good";
            Time = "13:50 - 14:40";
            NameOfPresenter = "Rob Ashton";
            Classroom = "/Assets/Images/green_path.png";
            VoteURL = "/Assets/Images/Vote/blue_tick.png";
            Description = "Frameworkless development with NPM is great - but patching together odd templating libraries and managing the DOM can end up causing performance issues if the team is not careful " +
                "to batch updates across components. That's where React comes in - utilizing React as a view engine within a typical framework-less set-up can result in cheap performance gains and " +
                "a sensible data management strategy throughout the app without any of that horrific two-way data binding found in other systems. See now as Rob covers how he uses React within a typical " +
                "application set-up, build tools, common patterns, common modules and patterns for easy wins for the entire team.";
            Category = "Green";
        }
    }

    public class FourthBlue : Lecture
    {
        public FourthBlue()
        {
            IdLecture = 5;
            Name = "Learning to Think 'The Designer Way'";
            Time = "13:50 - 14:40";
            NameOfPresenter = "Ben Hall";
            Classroom = "/Assets/Images/blue_path.png";
            VoteURL = "/Assets/Images/Vote/blue_tick.png";
            Description = "The best way to annoy a designer is to tell them that a red block should be blue, that a piece of text should be moved over, or to make the logo bigger " +
            "without any motivation or reasoning. The best way to give constructive feedback is to have evidence based on the site flow, design goals, visual principles and user behaviour " +
            "to support the problems that you see with the design. To provide this you need to start thinking like a designer. In this session Ben will discuss how " +
            "to start thinking like a designer, the core principals of design that affect our opinions of applications on a sub-concussion level based on the key design principles and how " +
            "to start defining potential solutions the designer way. Alongside this Ben will also attempt to provide answers to the “blank canvas” problem and how you can go from nothing to something, " +
            "an activity that designers seem to do without even thinking. As companies and communities embrace full-stack developers it’s time to start including design within that stack and not just a " +
            "single person’s responsibility.";
            Category = "Blue";
        }
    }

    public class FifthGreen : Lecture
    {
        public FifthGreen()
        {
            IdLecture = 8;
            Name = "Hacking Your Doorbell";
            Time = "15:00 - 15:50";
            NameOfPresenter = "Karl-Henrik Nillson";
            Classroom = "/Assets/Images/green_path.png";
            VoteURL = "/Assets/Images/Vote/blue_tick.png";
            Category = "Green";
            Description = "The internet of Things is a pretty big things by now and shows no sign of stopping - in fact over the last year the 'buzz' " +
                "about IoT have increased fivefolded and the .NET community is going to find loads of work in this Area. But the problem is that we currently don't have a good middle place " +
            "for aspiring developers that just want to build something cool, the developers that are not in IoT projects and are looking to dive in, learn and create home IoT projects." +
            "I have been creating network connected items for a long time and never really understood why the fact that my doorbell could be muted with a click of a button in my " +
            "WindowsPhone was such a big deal to my developer friends, especially since it was nothing more to it than a 433 Mhz transmitter pair, an mCU and a transistor to it. " +
            "We need to get it out there to all our super skilled developers that hacking hardware and connecting the physical world to our computers is cheap, easy and fun! " +
            "This talk asserts the possible technology choices such as Arduino, Netduino, AVR and some other interesting choices, how basic reverse engineering of existing hardware " +
            "is done (analysis, tools for analysis etc) and how to get started hacking hardware in a Microsoft/C# .NET (well mostly) environment TODAY!";
        }
    }

    public class FifthBlue : Lecture
    {
        public FifthBlue()
        {
            IdLecture = 9;
            Name = "Art of Saying NO";
            Time = "15:00 - 15:50";
            NameOfPresenter = "Kasia Mrowca";
            Classroom = "/Assets/Images/blue_path.png";
            VoteURL = "/Assets/Images/Vote/blue_tick.png";
            Category = "Blue";
            Description = "What to do when app requirements are „without any sense”? You might try to defend yourself from doing nonsense by estimating this accordingly " +
                "(infinity sounds like correct estimate ;))… This strategy is tricky though! Despite high estimates client might still decide to do feature in “not the wisest manner” " +
                "and make you miserable by the way. However, there is another way! Presentation will reveal the secret of art of saying no and expressing disagreement in a firm but user-friendly manner " +
                "(or friendly enough to not been thrown away from window or fired).";
        }
    }

    public class SixthGreen : Lecture
    {
        public SixthGreen()
        {
            IdLecture = 10;
            Name = "It Doesn't Work That Way in Enterprise";
            Time = "16:10 - 17:00";
            NameOfPresenter = "Peter Smith";
            Classroom = "/Assets/Images/green_path.png";
            VoteURL = "/Assets/Images/Vote/blue_tick.png";
            Description = "We've all heard it... or something similar. There's probably one senior guy at work who tells you this at least once a month. You've got an idea for an amazing new feature or practice that's going to save your company both time and money, " +
                "but it's too 'cutting edge'; your management fears the unfamiliar and you are cruelly stifled. 'It doesn't work like that in Enterprise' is a passionate and motivational story " +
                "about my journey as a developer in the face of one of the worst fallacies in our industry. The extremes of my experience will make you laugh & cry in equal measure, and maybe " +
                "help put your own frustrations into perspective. Just remember, it does get better... and you probably got off very f***g lightly!";
            Category = "Green";
        }
    }

    public class SixthBlue : Lecture
    {
        public SixthBlue()
        {
            IdLecture = 11;
            Name = "What is DevOps and How It Can Help My Business Succeed?";
            Time = "16:10 - 17:00";
            NameOfPresenter = "Paul Stack";
            Classroom = "/Assets/Images/blue_path.png";
            VoteURL = "/Assets/Images/Vote/blue_tick.png";
            Description = "DevOps is not just a buzzword. DevOps is all about culture. By achieving the right culture, then your engineers can really start to move fast. " +
                "Moving fast is something that we currently think we do. DevOps is not about tooling or giving developers root access to production systems.DevOps is about breaking down " +
                "the communication barriers to allow our entire IT team to work as 1. When the team has a culture of open communication and business understanding, then they can achieve anything! " +
                "During this talk, Paul will describe what DevOps is and how it is a great way for the entire business to achieve their goals. DevOps is not the new Agile! DevOps is about people :)";
            Category = "Blue";
        }
    }

    public class Seventh : Lecture
    {
        public Seventh()
        {
            IdLecture = 12;
            Name = "Software Architecture vs Code.";
            Time = "17:30 - 18:20";
            NameOfPresenter = "Simon Brown";
            Classroom = "/Assets/Images/neutral_path.png";
            VoteURL = "/Assets/Images/Vote/blue_tick.png";
            Description = "Software architecture and coding are often seen as mutually exclusive disciplines, despite us referring to higher level abstractions when we talk about our software. " +
                "You've probably heard others on your team talking about components, services and layers rather than objects when they're having discussions. Take a look at the codebase though. " +
                "Can you clearly see these abstractions or does the code reflect some other structure? If so, why is there no clear mapping between the architecture and the code? " +
                "Why do those architecture diagrams that you have on the wall say one thing whereas your code says another? In fact, why is it so hard to automatically generate a decent architecture " +
                "diagram from an existing codebase? Join us to explore this topic further.";
            Category = "Neutral";
        }
    }

    public class Party : Lecture
    {
        public Party()
        {
            Name = "Party!";
            Time = "18:30 - ??";
            Classroom = "/Assets/Images/neutral_path.png";
            Category = "Neutral";
        }
    }
}
