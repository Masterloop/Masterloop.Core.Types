namespace Masterloop.Core.Types.ImportExport
{
    public class SnapshotRequest
    {
        public string TID { get; set; }
        public string[] MIDs { get; set; }
        public bool AllObservations { get; set; }
        public int[] ObservationIds { get; set; }
        public bool AllSettings { get; set; }
        public int[] SettingIds { get; set; }
        public int[] PulseIds { get; set; }
    }
}
