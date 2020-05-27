namespace OOP_lab_4_15_2
{
    class Owner
    {
        private string _carBrand;
        private string _carNumber;
        private string _carColor;
        private string _personalInfo;

        public string CarBrand
        {
            get => _carBrand;
            set => _carBrand = value;
        }

        public string CarNumber
        {
            get => _carNumber;
            set => _carNumber = value;
        }

        public string CarColor
        {
            get => _carColor;
            set => _carColor = value;
        }

        public string PersonalInfo
        {
            get => _personalInfo;
            set => _personalInfo = value;
        }

        public Owner()
        {
            _carBrand = "Не вказано";
            _carNumber = "Не вказано";
            _carColor = "Не вказано";
            _personalInfo = "Не вказано";
        }

        public Owner(string carBrand, string carNumber, string carColor, string personalInfo)
        {
            _carBrand = carBrand;
            _carNumber = carNumber;
            _carColor = carColor;
            _personalInfo = personalInfo;
        }
    }
}
