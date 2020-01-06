using Gamebook.Model;
using Gamebook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gamebook.Services
{
    public class GameLogic
    {
        AchievementsRepository _ar = new AchievementsRepository();
        public bool Start(SessionStorage<GameState> _ss, SessionStorage<int> _cr, SessionStorage<bool> _w)
        {
            GameState empty = new GameState();
            empty.Start = 0;
            empty.CrowbarYN = 0;
            empty.KitchenHall2 = 0;
            empty.KnifeYN = 0;
            empty.BedroomHall3 = 0;
            empty.LivingRoomBasementWindow = 0;
            empty.KeepCrowbarYN = 0;
            empty.RunFight = 0;
            empty.PushPull = 0;
            empty.CrowbarInv = false;
            empty.KnifeInv = false;
            empty.FlashlightInv = false;
            empty.EnteredBasement = false;
            _ss.Save("_Game", empty);
            _cr.Save("_CurrentRoom", 1);
            _w.Save("_Waiting", true);
            return true;
        }
        public void Run(SessionStorage<GameState> _ss, SessionStorage<int> _cr, SessionStorage<bool> _w, SessionStorage<User> _u, int Choice)
        {
            Game(_ss, _cr, _w, _u, Choice);
        }
        public void Game(SessionStorage<GameState> _ss, SessionStorage<int> _cr, SessionStorage<bool> _w, SessionStorage<User> _u, int Choice)
        {
            GameState Game = _ss.LoadOrCreate("_Game");
            if (_ss.LoadOrCreate("_Game").Start == 1)
            {
                //turn around and leave - end
                Game.EnteredBasement = true;
                _ss.Save("_Game", Game);
                _cr.Save("_CurrentRoom", 2);
                Achievements achievements = _ar.GetAchievement(_u.LoadOrCreate("_User").Id);
                achievements.TurnAround = true;
                _ar.Update(achievements);
            }
            else if (_ss.LoadOrCreate("_Game").Start == 2)
            {
                //Garage
                _cr.Save("_CurrentRoom", 3);
                if(_ss.LoadOrCreate("_Game").CrowbarYN == 1)
                {
                    //take crowbar
                    Game.CrowbarInv = true;
                    _ss.Save("_Game", Game);
                    _cr.Save("_CurrentRoom", 4);
                    Game2(_ss, _cr, _w, _u, Choice);
                }
                else if(_ss.LoadOrCreate("_Game").CrowbarYN == 2)
                {
                    //leave crowbar
                    _cr.Save("_CurrentRoom", 5);
                    Game2(_ss, _cr, _w, _u, Choice);
                }
                else if (_w.LoadOrCreate("_Waiting") == true)
                {
                    Game.CrowbarYN = Choice;
                    _ss.Save("_Game", Game);
                    _w.Save("_Waiting", false);
                    Run(_ss, _cr, _w, _u, Choice);
                }
            }
            else if (_ss.LoadOrCreate("_Game").Start == 3)
            {
                //Hall
                _cr.Save("_CurrentRoom", 6);
                if(_ss.LoadOrCreate("_Game").KitchenHall2 == 1)
                {
                    //Kitchen
                    _cr.Save("_CurrentRoom", 7);
                    if(_ss.LoadOrCreate("_Game").KnifeYN == 1)
                    {
                        //take knife
                        Game.KnifeInv = true;
                        _ss.Save("_Game", Game);
                        _cr.Save("_CurrentRoom", 8);
                        Game2(_ss, _cr, _w, _u, Choice);
                    }
                    else if (_ss.LoadOrCreate("_Game").KnifeYN == 2)
                    {
                        //leave knife
                        _cr.Save("_CurrentRoom", 9);
                        Game2(_ss, _cr, _w, _u, Choice);
                    }
                    else if(_w.LoadOrCreate("_Waiting") == true)
                    {
                        Game.KnifeYN = Choice;
                        _ss.Save("_Game", Game);
                        _w.Save("_Waiting", false);
                        Run(_ss, _cr, _w, _u, Choice);
                    }

                }
                else if (_ss.LoadOrCreate("_Game").KitchenHall2 == 2)
                {
                    //Hall 2
                    _cr.Save("_CurrentRoom", 6);
                    Game2(_ss, _cr, _w, _u, Choice);
                }
                else if (_w.LoadOrCreate("_Waiting") == true)
                {
                    Game.KitchenHall2 = Choice;
                    _ss.Save("_Game", Game);
                    _w.Save("_Waiting", false);
                    Run(_ss, _cr, _w, _u, Choice);
                }
            }
            else if (_w.LoadOrCreate("_Waiting") == true)
            {
                Game.Start = Choice;
                _ss.Save("_Game", Game);
                _w.Save("_Waiting", false);
                Run(_ss, _cr, _w, _u, Choice);
            }
        }
        public void Game2(SessionStorage<GameState> _ss, SessionStorage<int> _cr, SessionStorage<bool> _w, SessionStorage<User> _u, int Choice)
        {
            GameState Game = _ss.LoadOrCreate("_Game");
            if (_ss.LoadOrCreate("_Game").BedroomHall3 == 1)
            {
                //Bedroom - end
                Game.EnteredBasement = true;
                _ss.Save("_Game", Game);
                _cr.Save("_CurrentRoom", 11);
                Achievements achievements = _ar.GetAchievement(_u.LoadOrCreate("_User").Id);
                achievements.BedroomAdventure = true;
                _ar.Update(achievements);
            }
            else if (_ss.LoadOrCreate("_Game").BedroomHall3 == 2)
            {
                //Hall3

                _cr.Save("_CurrentRoom", 12);
                if (_ss.LoadOrCreate("_Game").LivingRoomBasementWindow == 1)
                {

                    if (_ss.LoadOrCreate("_Game").CrowbarInv == true) { 
                        //Living Room - has crowbar
                        _cr.Save("_CurrentRoom", 13);
                        if (_ss.LoadOrCreate("_Game").KeepCrowbarYN == 1)
                        {
                            //keep crowbar
                            Game.FlashlightInv = true;
                            _ss.Save("_Game", Game);
                            _cr.Save("_CurrentRoom", 14);
                            if (_ss.LoadOrCreate("_Game").EnteredBasement == true)
                            {
                                Game3(_ss, _cr, _w, _u, Choice);
                            }
                        }
                        else if (_ss.LoadOrCreate("_Game").KeepCrowbarYN == 2)
                        {
                            //leave crowbar
                            Game.CrowbarInv = false;
                            Game.FlashlightInv = true;
                            _ss.Save("_Game", Game);
                            _cr.Save("_CurrentRoom", 15);
                            if (_ss.LoadOrCreate("_Game").EnteredBasement == true)
                            {
                                Game3(_ss, _cr, _w, _u, Choice);
                            }
                        }
                        else if (_w.LoadOrCreate("_Waiting") == true)
                        {
                            Game.KeepCrowbarYN = Choice;
                            _ss.Save("_Game", Game);
                            _w.Save("_Waiting", false);
                            Run(_ss, _cr, _w, _u, Choice);
                        }
                    }
                    else if (_ss.LoadOrCreate("_Game").CrowbarInv == false)
                    {
                        //doesn't have crowbar
                        _cr.Save("_CurrentRoom", 16);
                        Game.LivingRoomBasementWindow = 2;
                        _ss.Save("_Game", Game);
                        if (_ss.LoadOrCreate("_Game").EnteredBasement == true)
                        {
                            Game3(_ss, _cr, _w, _u, Choice);
                        }
                    }
                }
                else if (_ss.LoadOrCreate("_Game").LivingRoomBasementWindow == 2)
                {
                    //Basement
                    _cr.Save("_CurrentRoom", 17);
                    if (_ss.LoadOrCreate("_Game").EnteredBasement == true)
                    {
                        Game3(_ss, _cr, _w, _u, Choice);
                    }

                }
                else if (_ss.LoadOrCreate("_Game").LivingRoomBasementWindow == 3)
                {
                    //Window - end
                    Game.EnteredBasement = true;
                    _ss.Save("_Game", Game);
                    _cr.Save("_CurrentRoom", 18);
                    Achievements achievements = _ar.GetAchievement(_u.LoadOrCreate("_User").Id);
                    achievements.FallOut = true;
                    _ar.Update(achievements);
                }
                else if (_w.LoadOrCreate("_Waiting") == true)
                {
                    Game.LivingRoomBasementWindow = Choice;
                    _ss.Save("_Game", Game);
                    _w.Save("_Waiting", false);
                    Run(_ss, _cr, _w, _u, Choice);
                }
            }
            else if (_w.LoadOrCreate("_Waiting") == true)
            {
                Game.BedroomHall3 = Choice;
                _ss.Save("_Game", Game);
                _w.Save("_Waiting", false);
                Run(_ss, _cr, _w, _u, Choice);
            }
        }
        public void Game3(SessionStorage<GameState> _ss, SessionStorage<int> _cr, SessionStorage<bool> _w, SessionStorage<User> _u, int Choice)
        {
            GameState Game = _ss.LoadOrCreate("_Game");
            if (_ss.LoadOrCreate("_Game").FlashlightInv == true)
            {
                _cr.Save("_CurrentRoom", 19);
                //has flashlight
                if (_ss.LoadOrCreate("_Game").RunFight == 1)
                {
                    //run
                    if (_ss.LoadOrCreate("_Game").CrowbarInv == true)
                    {
                        //has crowbar - end
                        _cr.Save("_CurrentRoom", 20);
                        Achievements achievements = _ar.GetAchievement(_u.LoadOrCreate("_User").Id);
                        achievements.CrowbarsAreHeavy = true;
                        _ar.Update(achievements);
                    }
                    else if(_ss.LoadOrCreate("_Game").CrowbarInv == false)
                    {
                        _cr.Save("_CurrentRoom", 21);
                        //doesn't have crowbar
                        if (_ss.LoadOrCreate("_Game").PushPull == 1)
                        {
                            //push - end
                            _cr.Save("_CurrentRoom", 22);
                            Achievements achievements = _ar.GetAchievement(_u.LoadOrCreate("_User").Id);
                            achievements.PushingNeverWorks = true;
                            _ar.Update(achievements);
                        }
                        else if(_ss.LoadOrCreate("_Game").PushPull == 2)
                        {
                            //pull - win
                            _cr.Save("_CurrentRoom", 23);
                            Achievements achievements = _ar.GetAchievement(_u.LoadOrCreate("_User").Id);
                            achievements.win = true;
                            _ar.Update(achievements);
                        }
                        else if (_w.LoadOrCreate("_Waiting") == true)
                        {
                            Game.PushPull = Choice;
                            _ss.Save("_Game", Game);
                            _w.Save("_Waiting", false);
                            Run(_ss, _cr, _w, _u, Choice);
                        }
                    }
                }
                else if(_ss.LoadOrCreate("_Game").RunFight == 2)
                {
                    //fight
                    if(_ss.LoadOrCreate("_Game").KnifeInv == true)
                    {
                        //has knife - end
                        _cr.Save("_CurrentRoom", 24);
                        Achievements achievements = _ar.GetAchievement(_u.LoadOrCreate("_User").Id);
                        achievements.KnifeFight = true;
                        _ar.Update(achievements);
                    }
                    else if (_ss.LoadOrCreate("_Game").KnifeInv == false)
                    {
                        //doesn't have knife - end
                        _cr.Save("_CurrentRoom", 25);
                        Achievements achievements = _ar.GetAchievement(_u.LoadOrCreate("_User").Id);
                        achievements.KungFuFight = true;
                        _ar.Update(achievements);
                    }
                }
                else if (_w.LoadOrCreate("_Waiting") == true)
                {
                    Game.RunFight = Choice;
                    _ss.Save("_Game", Game);
                    _w.Save("_Waiting", false);
                    Run(_ss, _cr, _w, _u, Choice);
                }
            }
            else if (_ss.LoadOrCreate("_Game").FlashlightInv == false)
            {
                //doesn't have flashlight - end
                _cr.Save("_CurrentRoom", 26);
                if(_ss.LoadOrCreate("_Game").Start == 3 && _ss.LoadOrCreate("_Game").KitchenHall2 == 2 && _ss.LoadOrCreate("_Game").BedroomHall3 == 2 && _ss.LoadOrCreate("_Game").LivingRoomBasementWindow == 2)
                {
                    Achievements achievement = _ar.GetAchievement(_u.LoadOrCreate("_User").Id);
                    achievement.DoNothingAndDie = true;
                    _ar.Update(achievement);
                }
                Achievements achievements = _ar.GetAchievement(_u.LoadOrCreate("_User").Id);
                achievements.ItsDark = true;
                _ar.Update(achievements);
            }
        }
    }
}
