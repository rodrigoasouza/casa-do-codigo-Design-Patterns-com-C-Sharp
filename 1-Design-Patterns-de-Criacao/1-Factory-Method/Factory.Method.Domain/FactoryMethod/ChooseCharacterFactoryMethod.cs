using Factory.Method.Domain.Abstract.Domain;
using Factory.Method.Domain.Domain.Character;

namespace Factory.Method.Domain.FactoryMethod
{
    public class ChooseCharacterFactoryMethod
    {
        public ICharacter GetCharacter(string name)
        {
            ICharacter result = null;

            if (name is not null)
            {
                var nameLowCase = name.ToLowerInvariant();
                result = GetCharacterChoose(nameLowCase);
            }

            return result;
        }

        private ICharacter GetCharacterChoose(string name)
        {
            switch (name)
            {
                case "dollie freida": return new DollieFreida();
                case "jude keefe": return new JudeKeefe();
                case "delmar carlisa": return new DelmarCarlisa();
                default: return null;
            }
        }
    }
}
