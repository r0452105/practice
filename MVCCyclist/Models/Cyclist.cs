using System.ComponentModel.DataAnnotations;

namespace MVCCyclist.Models
{
    public class Cyclist
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public DateTime BirthDate { get; set; } = new DateTime(1900, 1, 1);

        public int Age
        {
            get { return (DateTime.Today - BirthDate).Days / 365; } // not sure about this one just yet
        }

        public double EstimateWeight { get; set; } = 45.00;
        public double Height { get; set; } = 1.45;
        public enum Team
        {

            [Display(Name = "AG2R Citroën Team")]
            AG2RCitroënTeam,
            [Display(Name = "Astana Qazaqstan Team")]
            AstanaQazaqstanTeam,
            [Display(Name = "Bahrain - Victorious")]
            BahrainVictorious,
            [Display(Name = "BORA - hansgrohe")]
            BORAhansgrohe,
            [Display(Name = "Cofidis")]
            Cofidis,
            [Display(Name = "EF Education-EasyPos")]
            EFEducationEasyPost,
            [Display(Name = "Groupama - FDJ")]
            GroupamaFDJ,
            [Display(Name = "INEOS Grenadiers")]
            INEOSGrenadiers,
            [Display(Name = "Intermarché - Wanty - Gobert Matériaux")]
            IntermarchéWantyGobertMatériaux,
            [Display(Name = "Israel - Premier Tech")]
            IsraelPremierTech,
            [Display(Name = "Jumbo-Visma")]
            JumboVisma,
            [Display(Name = "Lotto Soudal")]
            LottoSoudal,
            [Display(Name = "Movistar Team")]
            MovistarTeam,
            [Display(Name = "Quick-Step Alpha Vinyl Team")]
            QuickStepAlphaVinylTeam,
            [Display(Name = "Team BikeExchange - Jayco")]
            TeamBikeExchangeJayco,
            [Display(Name = "Team DSM")]
            TeamDSM,
            [Display(Name = "Trek - Segafredo")]
            TrekSegafredo,
            [Display(Name = "UAE Team Emirates")]
            UAETeamEmirates,
            [Display(Name = "No Team Assigned")]
            None,
        } //only worldtour teams as of now                                    NEED TO SOLVE !!!!!!!!
        public string Nationality { get; set; } = "No Country Available";


        #region CyclingStats 



        [Range(10, 100,
        ErrorMessage = "Value must be between 10 and 100.")]
        public int RY { get; set; } = 10; // Riding on the flat

        [Range(10, 100,
        ErrorMessage = "Value must be between 10 and 100.")]
        public int MO { get; set; } = 10; // Upwards on a climb

        [Range(10, 100,
        ErrorMessage = "Value must be between 10 and 100.")]
        public int DO { get; set; } = 10; // Descents

        [Range(10, 100,
        ErrorMessage = "Value must be between 10 and 100.")]
        public int CO { get; set; } = 10; // On the cobbles

        [Range(10, 100,
        ErrorMessage = "Value must be between 10 and 100.")]
        public int TT { get; set; } = 10; // Timetrial 

        [Range(10, 100,
        ErrorMessage = "Value must be between 10 and 100.")]
        public int PR { get; set; } = 10; // Prologue

        /* dfgdgh
         * Effects your speed during Time-Trials meaning you reach the finish with less energy used 
         * so you can use higher effort with higher TT/PRL stat, has no effect outside of Time-Trials;
         * TT stat has no effect under 5km Time-Trials,
         * PRL stat has no effect over 30km Time-trials;
         * 17,5km long Time-Trial is the point when TT and PR are 50-50% used;
         * while PRL decreases towards 30km from 5km long Time-Trials;
         * during Time-Trials when you run out of energy effort still makes difference meaning 99 effort is going to be faster than 60 effort.
         */

        [Range(10, 100,
        ErrorMessage = "Value must be between 10 and 100.")]
        public int SP { get; set; } = 10;

        [Range(10, 100,
        ErrorMessage = "Value must be between 10 and 100.")]
        public int ACC { get; set; } = 10;

        [Range(10, 100,
        ErrorMessage = "Value must be between 10 and 100.")]
        public int END { get; set; } = 10;

        [Range(10, 100,
        ErrorMessage = "Value must be between 10 and 100.")]
        public int RES { get; set; } = 10;

        [Range(10, 100,
        ErrorMessage = "Value must be between 10 and 100.")]
        public int REC { get; set; } = 10;

        [Range(10, 100,
        ErrorMessage = "Value must be between 10 and 100.")]
        public int HIL { get; set; } = 10;

        [Range(10, 100,
        ErrorMessage = "Value must be between 10 and 100.")]
        public int ATT { get; set; } = 10;

        #endregion 
        //These are just Physical stats (pretty repetitive)
    }
}
