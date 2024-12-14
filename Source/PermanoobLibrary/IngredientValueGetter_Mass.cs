using RimWorld;
using Verse;

namespace PermanoobLibrary
{
    public class IngredientValueGetter_Mass : IngredientValueGetter
    {
        public override float ValuePerUnitOf(ThingDef t)
        {
            return t.BaseMass;
        }

        public override string BillRequirementsDescription(RecipeDef r, IngredientCount ing)
        {
            return "PNoob_BillRequiresMass".Translate(ing.GetBaseCount());
        }
        public override string ExtraDescriptionLine(RecipeDef r)
        {
            return "(kg)";
        }
    }
}
