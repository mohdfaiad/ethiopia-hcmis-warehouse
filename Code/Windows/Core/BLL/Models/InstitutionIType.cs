
// Generated by MyGeneration Version # (1.2.0.7)

using DAL;

namespace BLL
{
	public class InstitutionIType : _InstitutionIType
	{
        public static int PfsaHub;
        public static int Vaccine;
	    

		public InstitutionIType()
		{
		
		}

        public static bool IsPfsa(GeneralInfo generalInfo)
        {
            return generalInfo.InstitutionITypeID == PfsaHub;
        }
      
        public static bool IsVaccine(GeneralInfo generalInfo)
        {
            return generalInfo.InstitutionITypeID == Vaccine;
        }
	}
}