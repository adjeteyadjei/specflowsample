using System;
using TechTalk.SpecFlow;
using PayScale;
using NUnit.Framework;

namespace PayScaleTest.Payscale
{
    [Binding]
    public class DeveloperProfileSteps
    {
        private Context _context = new Context();
        [Given(@"The age is (.*)")]
        public void GivenTheAgeIs(int p0)
        {
            _context.age = p0;
        }
        
        [Given(@"Gender is male")]
        public void GivenGenderIsMale()
        {
            _context.gender = Gender.Male;
        }
        
        [Given(@"Marital status is single")]
        public void GivenMaritalStatusIsSingle()
        {
            _context.isMarried = false;
        }
        
        [Given(@"Has no children")]
        public void GivenHasNoChildren()
        {
            _context.numberOfChildren = 0;
        }
        
        [Given(@"Marital status is married")]
        public void GivenMaritalStatusIsMarried()
        {
            _context.isMarried = true;
        }
        
        [Given(@"Has (.*) child")]
        public void GivenHasChild(int p0)
        {
            _context.numberOfChildren = p0;
        }
        
        [When(@"We calculate pay")]
        public void WhenWeCalculatePay()
        {
        }
        
        [Then(@"The pay should be (.*) dollars")]
        public void ThenThePayShouldBeDollars(int p0)
        {
            //todo: what happens if the key is not in the dictionary
            var expectedPay = _context.ComputePay();
            Assert.AreEqual(expectedPay, p0);
        }
        [Given(@"Years of experience is (.*)")]
        public void GivenYearsOfExperienceIs(int p0)
        {
            _context.yearsOfExperience = p0;
        }

        internal class Context
        {
            public int age { get; set; }
            public Gender gender { get; set; }
            public bool isMarried { get; set; }
            public int numberOfChildren { get; set; }
            public int yearsOfExperience { get; set; }

            public int ComputePay() => PayScale.PayScale.Calculate(age, yearsOfExperience, gender, isMarried, numberOfChildren);
        }
    }

    
}
