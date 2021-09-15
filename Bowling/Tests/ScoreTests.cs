using Bowling;

using Xunit;

namespace Tests
{
    public class ScoreTests
    {
        [Fact (DisplayName = "No rolled game score is 0")]
        public void NoRolledGameScoreIsZero () => Assert.Equal (0, new Game ().Score);

        [Fact (Skip = "todo later in kata")]
        public void FinalStrikeGame ()
        {
            var game = new Game ()
                .Roll (9)
                .Roll (1)
                .Roll (4)
                .Roll (5)
                .Roll (7)
                .Roll (2)
                .Roll (4)
                .Roll (6)
                .Roll (5)
                .Roll (5)
                .Roll (10)
                .Roll (5)
                .Roll (3)
                .Roll (6)
                .Roll (2)
                .Roll (10)
                .Roll (10)
                .Roll (10)
                .Roll (10);

            Assert.Equal (161, game.Score);
        }

        [Fact (Skip = "todo later in kata")]
        public void NoFinalStrikeGame ()
        {
            var game = new Game ()
                .Roll (4)
                .Roll (2)
                .Roll (4)
                .Roll (5)
                .Roll (3)
                .Roll (5)
                .Roll (3)
                .Roll (2)
                .Roll (4)
                .Roll (5)
                .Roll (3)
                .Roll (5)
                .Roll (4)
                .Roll (6)
                .Roll (10)
                .Roll (2)
                .Roll (8)
                .Roll (6)
                .Roll (3);

            Assert.Equal (110, game.Score);
        }
    }
}
