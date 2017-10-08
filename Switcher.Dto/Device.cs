namespace Switcher.Dto
{
    public class Device
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public bool IsPrimary { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Device device = obj as Device;

            if (device == null)
                return false;

            return (Name == device.Name && Title == device.Title);
        }

        public bool IsEmpty()
        {
            return string.IsNullOrEmpty(Name) && string.IsNullOrEmpty(Title);
        }
    }
}
