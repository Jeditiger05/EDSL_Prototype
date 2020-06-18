﻿using EDSL_Prototype.DAL;
using EDSL_Prototype.Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EDSL_Prototype.Handlers
{
    class Fixtures
    {
        public static void GetGames(string divName)
        {
            Division division = DAFunctions.ReadDivision(divName);
            List<string> teams = DAFunctions.GetDivisionTeams(division.DivisionID);
            List<Round> rounds = new List<Round>();
            List<Game> fixtures = CalculateFixtures(teams);



            //var teams = new string[] { "A", "B", "C", "D" };
            //List<Fixture> fixtures = CalculateFixtures(teams);
            DAFunctions.fixtures = fixtures;
        }

        public static List<Game> CalculateFixtures(List<string> teams)
        {
            //create a list of all possible fixtures (order not important)
            List<Game> fixtures = new List<Game>();
            for (int i = 0; i < teams.Count; i++)
            {
                for (int j = 0; j < teams.Count; j++)
                {
                    if (teams[i] != teams[j])
                    {
                        fixtures.Add(new Game(j, teams[i], teams[j], 0, 0));
                    }
                }
            }

            fixtures.Reverse();//reverse the fixture list as we are going to remove element from this and will therefore have to start at the end

            //calculate the number of game weeks and the number of games per week
            int gameweeks = (teams.Count - 1) * 2;
            int gamesPerWeek = gameweeks / 2;

            List<Game> sortedFixtures = new List<Game>();

            //foreach game week get all available fixture for that week and add to sorted list
            for (int i = 0; i < gameweeks; i++)
            {
                sortedFixtures.AddRange(TakeUnique(fixtures, gamesPerWeek));
            }

            return sortedFixtures;
        }

        public static List<Game> TakeUnique(List<Game> fixtures, int gamesPerWeek)
        {
            List<Game> result = new List<Game>();

            //pull enough fixture to cater for the number of game to play
            for (int i = 0; i < gamesPerWeek; i++)
            {
                //loop all fixture to find an unused set of teams
                for (int j = fixtures.Count - 1; j >= 0; j--)
                {
                    //check to see if any teams in current fixtue have already been used this game week and ignore if they have
                    if (!result.Any(r => r.HomeTeam == fixtures[j].HomeTeam || r.AwayTeam == fixtures[j].HomeTeam || 
                    r.HomeTeam == fixtures[j].AwayTeam || r.AwayTeam == fixtures[j].AwayTeam))
                    {
                        //teams not yet used
                        result.Add(fixtures[j]);
                        fixtures.RemoveAt(j);
                    }
                }
            }

            return result;
        }
    }
}
