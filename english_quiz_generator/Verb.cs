using System;
using System.Collections.Generic;
using System.Text;

namespace english_quiz_generator
{
    class Verb
    {
        public string Infinitive { get; }
        public string PastSimple { get; set; }
        public string PastParticiple { get; set; }
        public Verb(string infinitive_form)
        {
            if (infinitive_form == null)
                throw new ArgumentNullException("Argument infinitive_form is null.");

            if (infinitive_form == "")
                throw new ArgumentException("Argument infinitive_form is empty.");

            Infinitive = infinitive_form;
        }
    }
}
