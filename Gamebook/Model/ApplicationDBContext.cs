using Gamebook.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gamebook.Models
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<RoomTexts> roomTexts { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Achievements> achievements { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasData(new User { Id = 1, login = "first", password = "first" });
            modelBuilder.Entity<Achievements>().HasData(new Achievements { Id = 1 });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 1, text = "You enter the presumably haunted house, looking for any clues of the incident that happened a year ago. As you look around you see that there are exactly 3 doors, one leads to the outside, one leads to a Garage and one leads to a Hallway. Which one do you choose?", linktext1 = "Outside", linktext2 = "Garage", linktext3="Hallway" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 2, text = "You go outside, decide that it isn't worth the risk of a monster or something and leave.", linktext1 = "", linktext2 = "", linktext3 = "" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 3, text = "You entered the garage and as you look around, you find a crowbar, thinking that it might be useful. Would you like to take it?", linktext1 = "Yes", linktext2 = "No", linktext3 = "" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 4, text = "You take the crowbar and exit through another door in the garage. You enter the Hallway. In the darkness, you hear someone sing behind a door to a bedroom. Where would you like to go?", linktext1 = "bedroom", linktext2 = "continue down the hallway", linktext3 = "" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 5, text = "You decide to leave the crowbar there and exit through another door in the garage. You enter the Hallway. In the darkness, you hear someone sing behind a door to a bedroom. Where would you like to go?", linktext1 = "bedroom", linktext2 = "even more hallway", linktext3 = "" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 6, text = "You enter the hallway. You see a door to a kitchen. Would you like to go in there, or continue down the hallway", linktext1 = "kitchen", linktext2 = "continue down the hallway hallway", linktext3 = "" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 7, text = "As you enter the kitchen, you notice a knife stuck in the wall. Would you like to take it?", linktext1 = "yes", linktext2 = "no", linktext3 = "" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 8, text = "You pull the knife out of the wall, and take it with you on an adventure to the hallway. You hear someone sing behind a door to a bedroom. Would you like to check it out or do you continue down the hallway?", linktext1 = "bedroom", linktext2 = "continue down the hallway", linktext3 = "" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 9, text = "You leave the knife be and go to the hallway. You hear someone sing behind a door to a bedroom. Would you like to check it out or do you continue down the hallway?", linktext1 = "bedroom", linktext2 = "continue down the hallway", linktext3 = "" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 10, text = "You enter a hallway. You hear someone sing behind a door to a bedroom. Do you want to see who's singing, or do you want to continue down the hallway", linktext1 = "bedroom", linktext2 = "continue down the hallway", linktext3 = "" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 11, text = "You decide to enter the hallway. You immediatelly realise how big of a mistake that was. The song from a little girl standing in the middle of the room immediatelly stops and she looks straight at you with her black eyes. You pass out and never wake up again.", linktext1 = "", linktext2 = "", linktext3 = "" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 12, text = "Ignoring the singing, you continue down the hallway only to find 3 things. a living room that's boarded up, probably accesible with a crowbar, stairs to the basement and a very cool open window that you feel extreme urge to check out. Which one do you choose?", linktext1 = "living room", linktext2 = "Basement", linktext3 = "cool window, check it out" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 13, text = "You feel happy that you grabbed that crowbar, get in there and find a flashlight. Such an awesome source of light! Would you like to keep your crowbar?", linktext1 = "yes", linktext2 = "no", linktext3 = "" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 14, text = "You decide to keep your crowbar and continue down the stairs into the basement.", linktext1 = "", linktext2 = "", linktext3 = "" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 15, text = "You decide to leave your crowbar there and continue down the stairs into the basement.", linktext1 = "", linktext2 = "", linktext3 = "" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 16, text = "You try to open the door to the living room, but you can't. If only you had that crowbar now. The only way to go is now to the basement.", linktext1 = "", linktext2 = "", linktext3 = "" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 17, text = "Down to the basement you go!", linktext1 = "", linktext2 = "", linktext3 = "" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 18, text = "You look out of the cool window. You looked so close that you fell out and died.", linktext1 = "", linktext2 = "", linktext3 = "" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 19, text = "As you enter the basement, you suddenly see a not very friendly looking monster coming your way. Do you run or fight?", linktext1 = "run", linktext2 = "fight", linktext3 = "" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 20, text = "You decide to run, but the crowbar is so heavy that the monster catches up and rips you apart.", linktext1 = "", linktext2 = "", linktext3 = "" });          
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 21, text = "You're running as fast as you can and now there's a door. Will you push or pull?", linktext1 = "push", linktext2 = "pull", linktext3 = "" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 22, text = "You tried pushing, it didn't work and you don't have the time to try pulling now. The monster catched up to you and you died horribly.", linktext1 = "", linktext2 = "", linktext3 = "" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 23, text = "You pulled and it opened, so you closed it behind you and ran. The monster didn't know how doors work and you got away. ", linktext1 = "", linktext2 = "", linktext3 = "" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 24, text = "You decide that the knife you got is a really good weapon against a deadly monster. It wasn't and you died.", linktext1 = "", linktext2 = "", linktext3 = "" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 25, text = "You suddenly feel like you can defeat the monster without any weapons. You try it and fail horribly. You died.", linktext1 = "", linktext2 = "", linktext3 = "" });
            modelBuilder.Entity<RoomTexts>().HasData(new RoomTexts { Id = 26, text = "You don't have a flashlight and it's dark. You feel a breath on your back. A monster ripped you apart.", linktext1 = "", linktext2 = "", linktext3 = "" });
        }
    }
}
