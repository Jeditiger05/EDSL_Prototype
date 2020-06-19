using EDSL_Prototype.DAL;
using EDSL_Prototype.Models;
using MoreLinq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace EDSL_Prototype.Handlers
{
    class Fixtures
    {
        public static void GetGames(string seasName, string divName)
        {
            Division division = DAFunctions.ReadDivision(divName);
            Season season = DAFunctions.ReadSeason(seasName);
            List<string> teams = DAFunctions.GetDivisionTeams(division.DivisionID);

            var random = new Random();

            teams = teams.OrderBy(item => random.Next()).ToList();

            List<Game> fixtures = CalculateFixtures(teams);
            DAFunctions.fixtures = fixtures.OrderBy(o => o.GameNo).ToList();

            List<Round> rounds = new List<Round>();

            int round = 0;
            for (int i = 0; i < season.SeasonDates.Count; i++)
            {
                rounds.Add( new Round(i + 1, season.SeasonDates[i], 1));
                for (int j = 0; j < 5; j++)
                {
                    rounds[i].GameList.Add(new Game());
                }
            }

            foreach (var batch in fixtures.Batch(5))
            {
                if (batch.ToList().Count == 5)
                {
                    rounds[round].GameList = batch.ToList();
                    round += 1;
                }

            }

            DAFunctions.allDraws.Add(rounds);
        }


        public static List<Game> CalculateFixtures(List<string> teams)
        {
            int gNo = 0;
            //create a list of all possible fixtures (order not important)
            List<Game> fixtures = new List<Game>();
            for (int i = 0; i < teams.Count; i++)
            {
                for (int j = 0; j < teams.Count; j++)
                {
                    if (teams[i] != teams[j])
                    {
                        fixtures.Add(new Game(gNo, teams[i], teams[j], 0, 0));
                    }
                    gNo++;
                }
            }

            //reverse the fixture list as we are going to remove element from this and will therefore have to start at the end
            fixtures.Reverse();

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
