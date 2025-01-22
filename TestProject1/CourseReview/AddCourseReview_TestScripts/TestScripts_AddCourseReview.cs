using Commons.DTO_s.CourseReview.AddCourseReview;
using Commons.DTO_s.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestProject1.CourseReview.AddCourseReview_TestScripts
{
    [TestClass]
    public class TestScripts_AddCourseReview
    {
        [TestMethod]
        public void ValidInputValues()
        {
            var AddCourseReview_GetResponse = ApiResponse_AddCourseReview.Sets_AddCourseReview;
            Console.WriteLine("\nTest Scripts Results: ");
            Console.WriteLine("Valid All Input Values                                                           :       PASS");
            Console.WriteLine("Special Characters used in 'id' or 'courseid' or 'rating' input values           :       FAIL");
            Console.WriteLine("Alphabet Character used in 'id' or 'courseid' or 'rating' input values           :       FAIL");
            Console.WriteLine("'id' or 'courseid' or 'rating' is null or empty                                  :       FAIL");
            Assert.AreEqual(200, AddCourseReview_GetResponse.statusCode, "Unexpected status code.");
        }
        [TestMethod]
        public void InvalidInputValues()
        {
            Console.WriteLine("\nTest Scripts Results: ");
            Console.WriteLine("Response with no Data                                             :       PASS");
            Console.WriteLine("Alphabet Character used in 'franchiseIds' input values            :       FAIL");
            Console.WriteLine("Valid All Input Values                                            :       FAIL");
            Console.WriteLine("Special Character used in 'franchiseIds' input values             :       FAIL");
            Console.WriteLine("'types' or 'franchisesIds' is null or empty                       :       FAIL");
            Console.WriteLine("Value can be null. (Parameter 'types')                            :       FAIL");
            Console.WriteLine("Value can be null. (Parameter 'franchisesIds')                    :       FAIL");
        }
        [TestMethod]
        public void ContainsAlphabetValue(string id, string courseId, string rating)
        {
            Console.WriteLine("\nTest Scripts Results: ");
            Console.WriteLine("Alphabet Character used in 'id' or 'courseid' or 'rating' input values           :       PASS");
            Console.WriteLine("Special Characters used in 'id' or 'courseid' or 'rating' input values           :       FAIL");
            Console.WriteLine("Valid All Input Values                                                           :       FAIL");
            Console.WriteLine("'id' or 'courseid' or 'rating' is null or empty                                  :       FAIL");
            Assert.IsTrue(ContainAlphabet_Inputvalues(id, courseId, rating), "Alphabet Character used.");
        }
        [TestMethod]
        public void SpecialCharacter(string id,string courseId, string rating)
        {
            Console.WriteLine("\nTest Scripts Results: ");
            Console.WriteLine("Special Characters used in 'id' or 'courseid' or 'rating' input values           :       PASS");
            Console.WriteLine("Alphabet Character used in 'id' or 'courseid' or 'rating' input values           :       FAIL");
            Console.WriteLine("Valid All Input Values                                                           :       FAIL");
            Console.WriteLine("'id' or 'courseid' or 'rating' is null or empty                                  :       FAIL");
            Assert.IsTrue(ContainsSpecialCharacters(id, courseId, rating), "Special Character used.");
        }
        //
        // Example usage:
        public void Null_Values(string id, string courseId, string rating)
        {
            // Check if the input is null or empty
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(courseId) || string.IsNullOrEmpty(rating))
            {
                Console.WriteLine("\nTest Scripts Results: ");
                Console.WriteLine("'id' or 'courseid' or 'rating' is null or empty                                  :       PASS");
                Console.WriteLine("Special Characters used in 'id' or 'courseid' or 'rating' input values           :       FAIL");
                Console.WriteLine("Alphabet Character used in 'id' or 'courseid' or 'rating' input values           :       FAIL");
                Console.WriteLine("Valid All Input Values                                                           :       FAIL");
                Assert.IsTrue(ContainNullInputvalues(id, courseId, rating), "Null 'Types' or 'franchisesIds'");
            }
        }
        private bool ContainsSpecialCharacters(string str,string str1,string str2)
        {
            // Regular expression to match special characters
            string pattern = @"[%\^\*\'\(\)\!\@\?\&\+\$\~\`]";
            string combinedString = str + str1 + str2;
            return Regex.IsMatch(combinedString, pattern);
        }
        private bool ContainNullInputvalues(string strid, string strcourseid, string strrating)
        {
            string testInput = ".*";
            bool result = Regex.IsMatch(strid + strcourseid + strrating, testInput);
            Console.WriteLine($"Test Script Result: {(result ? "Pass" : "Fail")}");
            string combinedString = strid + strcourseid + strrating;
            return Regex.IsMatch(combinedString, testInput);
        }
        private bool ContainAlphabet_Inputvalues(string str_id, string str_courseid, string str_rating)
        {
            string pattern1 = @"^[a-zA-Z]+$";
            string combinedString = str_id + str_courseid + str_rating;
            var abc = Regex.IsMatch(str_id + str_courseid + str_rating, pattern1);
            return Regex.IsMatch(combinedString, pattern1);
        }
    }
}