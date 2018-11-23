namespace Masterloop.Core.Types.ImportExport
{
    public class SnapshotRequest
    {
        public string[] MIDs { get; set; }
        public int[] ObservationIds { get; set; }
        public int[] SettingIds { get; set; }
        public int[] PulseIds { get; set; }
    }
}
