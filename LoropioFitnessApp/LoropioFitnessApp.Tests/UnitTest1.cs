using LoropioFitnessApp.Activity;

namespace LoropioFitnessApp.Tests
{
    public class SportActivityTests
    {
        [Fact]
        public void CalculateAverageInKmPerHour_ShouldCalculateCorrectly()
        {
            // Arrange
            var distance = 1000; 
            DateOnly date = new DateOnly(2022,12,12);
            Feeling feeling = Feeling.Good;
            TimeSpan time = new TimeSpan(hours:2,minutes:0,seconds:0);
            var activity = new SportActivity(distance, date, feeling, time);

            // Act
            var averageSpeedKmPerHour = activity.CalculateAverageSpeedInKmPerHour();

            // Assert
            Assert.Equal(0.5, averageSpeedKmPerHour, 2); 
        }

        [Fact]
        public void CalculateAverageInMPerSecond_ShouldCalculateCorrectly()
        {
            // Arrange
            var distance = 10000; 
            DateOnly date = new DateOnly(2022, 12, 12);
            Feeling feeling = Feeling.VeryStrong;
            TimeSpan time = new TimeSpan(hours: 0, minutes: 0, seconds: 10);
            var activity = new SportActivity(distance, date, feeling, time);

            // Act
            var averageSpeedMilePerSecond = activity.CalculateAverageSpeedMetersPerSecond();

            // Assert
            Assert.Equal(1000, averageSpeedMilePerSecond, 2); 
        }
    }
}