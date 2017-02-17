using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayScale
{
    public static class PayScale
    {
        public static int Calculate(int age,int experience,Gender gender,bool married,int numberOfChildren)
        {
            var result = 0;
            result += ComputeAgeScale(age);
            result += ComputeExperienceScale(experience);
            result += ComputeGenderScale(gender);
            result += ComputeIsMarriedScale(married);
            result += ComputeNumberOfChildrenScale(numberOfChildren);
            result += ComputeSpecialScale(age, experience);
            return result * 45;
        }
        private static int ComputeGenderScale(Gender gender) => gender == Gender.Male ? 6 : 8;
        private static int ComputeIsMarriedScale(bool isMarried) => isMarried ? 8 : 5;
        private static int ComputeNumberOfChildrenScale(int numberOfChildren) => Math.Max(1, 10 - numberOfChildren);
        private static int ComputeSpecialScale(int age, int experience) => (age < 30 && experience > 3) ? 5 : 0;
        private static int ComputeExperienceScale(int experience) => Math.Min(experience, 10);
        private static int ComputeAgeScale(int age)
        {
            if (age < 30) return 5;
            if (age <= 40) return 7;
            if (age <= 50) return 8;
            return 4;
        }

    }
    public enum Gender
    {
        Male,
        Female
    }
   
}
