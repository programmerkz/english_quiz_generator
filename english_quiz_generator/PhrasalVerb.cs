using System;
using System.Collections.Generic;
using System.Text;

namespace english_quiz_generator
{
    class PhrasalVerb
    {
        public Verb Verb { get; }
        public string Preposition { get; }
        public PhrasalVerb(Verb verb, string preposition)
        {
            if (Verb == null)
                throw new ArgumentNullException("Argument verb is null.");

            if (preposition == null)
                throw new ArgumentNullException("Argument preposition is null.");

            if (preposition == "")
                throw new ArgumentException("Argument preposition is empty.");

            Verb = verb;
            Preposition = preposition;
        }
        public PhrasalVerb(string verb, string preposition)
        {
            if (verb == null)
                throw new ArgumentNullException("Argument verb is null.");

            if (verb == "")
                throw new ArgumentException("Argument verb is empty.");

            if (preposition == null)
                throw new ArgumentNullException("Argument preposition is null.");

            if (preposition == "")
                throw new ArgumentException("Argument preposition is empty.");

            Verb = new Verb(verb);
            Preposition = preposition;
        }
    }
}
