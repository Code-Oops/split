using System;
using System.Collections.Generic;
using System.Linq;
using split.Console.Models;
using split.Console.Models.Blackjack;
using Xunit;

namespace split.Console.Tests.Models
{
    public class BlackjackTestShould
    {
        // todo: determine whether this needs to use the IDisposable interface. 
        // if it does, BlackjackGame should also implement it. 
        BlackjackGame blackjack;


        public BlackjackTestShould()
        {
            blackjack = new BlackjackGame();
        }

		public static IEnumerable<object[]> GetCardsForTwentyOne1()
		{
            yield return new object[]{
                new Card[]{
                    new Card(SuitType.Club, RankType.King),
                    new Card(SuitType.Diamond, RankType.Nine),
                    new Card(SuitType.Heart, RankType.Two)
                }
            };
        }

		public static IEnumerable<object[]> GetCardsForTwentyOne2()
		{
			yield return new object[]{
				new Card[]{
					new Card(SuitType.Club, RankType.Queen),
					new Card(SuitType.Diamond, RankType.Eight),
					new Card(SuitType.Heart, RankType.Three)
				}
			};
		}

		public static IEnumerable<object[]> GetCardsForUnder1()
		{
			yield return new object[]{
				new Card[]{
					new Card(SuitType.Club, RankType.Three),
					new Card(SuitType.Diamond, RankType.Five),
					new Card(SuitType.Heart, RankType.Three)
				}
			};
		}

		public static IEnumerable<object[]> GetCardsForUnder2()
		{
			yield return new object[]{
				new Card[]{
					new Card(SuitType.Club, RankType.Ten),
					new Card(SuitType.Diamond, RankType.Five),
					new Card(SuitType.Heart, RankType.Three)
				}
			};
		}

		public static IEnumerable<object[]> GetCardsForOver1()
		{
			yield return new object[]{
				new Card[]{
					new Card(SuitType.Club, RankType.King),
					new Card(SuitType.Diamond, RankType.King),
					new Card(SuitType.Heart, RankType.Three)
				}
			};
		}

		public static IEnumerable<object[]> GetCardsForOver2()
		{
			yield return new object[]{
				new Card[]{
					new Card(SuitType.Club, RankType.Ten),
					new Card(SuitType.Diamond, RankType.Ten),
					new Card(SuitType.Heart, RankType.Three)
				}
			};
		}

        [Theory]
        [MemberData(nameof(GetCardsForTwentyOne1))]
        [MemberData(nameof(GetCardsForTwentyOne2))]
        public void ReturnWonWhenScoreIsTwentyOne(Card[] hand)
        {
            var actual = blackjack.HaveIWon(hand);
            Assert.Equal(VictoryType.TwentyOne, actual);
        }

		[Theory]
		[MemberData(nameof(GetCardsForUnder1))]
		[MemberData(nameof(GetCardsForUnder2))]
		public void ReturnUnderWhenScoreBelowTwentyOne(Card[] hand)
		{
			var actual = blackjack.HaveIWon(hand);
			Assert.Equal(VictoryType.Under, actual);
		}

		[Theory]
		[MemberData(nameof(GetCardsForOver1))]
		[MemberData(nameof(GetCardsForOver2))]
		public void ReturnUnderWhenScoreOverTwentyOne(Card[] hand)
		{
			var actual = blackjack.HaveIWon(hand);
			Assert.Equal(VictoryType.Over, actual);
		}


       

    }
}
