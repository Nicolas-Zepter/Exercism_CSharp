namespace Exercism_CSharp
{
    #region Task Description
    /*
    Given students' names along with the grade they are in, create a roster for the school.
    In the end, you should be able to:
    Add a student's name to the roster for a grade:
    "Add Jim to grade 2."
    "OK."
    Get a list of all students enrolled in a grade:
    "Which students are in grade 2?"
    "We've only got Jim right now."
    Get a sorted list of all students in all grades. Grades should be sorted as 1, 2, 3, etc., and students within a grade should be sorted alphabetically by name.
    "Who is enrolled in school right now?"
    "Let me think. We have Anna, Barb, and Charlie in grade 1, Alex, Peter, and Zoe in grade 2, and Jim in grade 5. So the answer is: Anna, Barb, Charlie, Alex, Peter, Zoe, and Jim."
    Note that all our students only have one name (it's a small town, what do you want?), and each student cannot be added more than once to a grade or the roster. 
    If a test attempts to add the same student more than once, your implementation should indicate that this is incorrect.
    */
    #endregion

    public class GradeSchool
    {
        #region Fields

        private SortedDictionary<int, SortedSet<string>> _schoolRoster = new();

        #endregion

        #region Methods
        /// <summary>
        /// Checks if a student is already registered in the school, and if not, adds them to the roster for their corresponding grade.
        /// </summary>
        /// <param name="student">The student to examine.</param>
        /// <param name="grade">The grade to add student to.</param>
        /// <returns>True if the student was successfully added, otherwise false.</returns>
        public bool Add(string student, int grade)
        {
            if (!_schoolRoster.SelectMany(kvp => kvp.Value).Contains(student))
            {
                if (!_schoolRoster.ContainsKey(grade))
                {
                    _schoolRoster.Add(grade, new SortedSet<string>());
                }
                _schoolRoster[grade].Add(student);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Gets the names of all students currently registered at the school, irregardless of grade.
        /// </summary>
        /// <returns>A <see cref="System.Collections.Generic.HashSet{System.String}"/> containing the names of all students.</returns>
        public IEnumerable<string> Roster() => _schoolRoster.SelectMany(kvp => kvp.Value);

        /// <summary>
        /// Gets the names of all students currently registered in grade.
        /// </summary>
        /// <param name="grade">The grade to be examined.</param>
        /// <returns>A <see cref="System.Collections.Generic.SortedSet{System.String}"/> containing the names of all students in grade.</returns>
        public IEnumerable<string> Grade(int grade)
        {
            if (!_schoolRoster.ContainsKey(grade))
            {
                return Enumerable.Empty<string>();
            }

            return _schoolRoster[grade];
        }
        #endregion
    }
}
