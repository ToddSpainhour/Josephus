using System;
using Xunit;

namespace Josephus.Tests
{
    public class The_right_person_survives
    {

        // testing is all about repeating yourself with only small changes

        [Fact] // fact attribute that sit atop a method
        public void one_person_with_an_interval_of_one_then_only_person_should_survive()
        {
            //every tests is made up of three parts

            // Arrange (Given a range of circumstances)

            var numberOfPeople = 1;
            var killingInterval = 1;
            var expectedResult = 1;

            var solver = new JosephusSolver();

            // Act (When)
            var solution = solver.Solve(numberOfPeople, killingInterval);



            // Assert (Then, this is what I expect...)
            // is the thing they told me correct? If yes, keep on going.
            Assert.Equal(expectedResult, solution);
        }

        //Attribute, public, void, and no parameters
        [Fact]
        public void when_two_people_with_an_interval_of_one_then_the_second_person_survives()
        {
            var numberOfPeople = 2;
            var killingInterval = 1;
            var expectedResult = 2;

            var solver = new JosephusSolver();

            // Act
            var solution = solver.Solve(numberOfPeople, killingInterval);

            // Assert
            Assert.Equal(expectedResult, solution);
        }

        //Attribute, public, void, and no parameters
        [Fact]
        public void when_two_people_with_an_interval_of_two_then_the_seventh_person_survives()
        {
            var numberOfPeople = 7;
            var killingInterval = 2;
            var expectedResult = 7;

            var solver = new JosephusSolver();

            // Act
            var solution = solver.Solve(numberOfPeople, killingInterval);

            // Assert
            Assert.Equal(expectedResult, solution);
        }

        [Fact]
        public void when_two_people_with_an_interval_of_two_then_the_137th_person_survives()
        {
            var numberOfPeople = 137;
            var killingInterval = 2;
            var expectedResult = 19;

            var solver = new JosephusSolver();

            // Act
            var solution = solver.Solve(numberOfPeople, killingInterval);

            // Assert
            Assert.Equal(expectedResult, solution);
        }



        [Theory] // theories can take in parameters. Can test something with many different options
        [InlineData(137,2,19)]
        [InlineData(1, 1, 2)]
        [InlineData(2, 1, 1)]
        [InlineData(7, 3, 7)]

        public void given_a_killing_number_and_a_number_of_people_the_correct_solution_is_returned(int numberOfPeople, int killingInterval, int expectedResult)
        {
            
            var solver = new JosephusSolver();

            // Act
            var solution = solver.Solve(numberOfPeople, killingInterval);

            // Assert
            Assert.Equal(expectedResult, solution);
        }

    }
}

