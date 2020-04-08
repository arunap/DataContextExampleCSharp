using DataContextExampleCSharp.Helpers;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataContextExampleCSharp.Models
{
    [Table("CallExtractionProgress")]
    public class CallExtractionProgress
    {
        public int Id { get; set; }
        public Guid ScheduleId { get; set; }
        public Guid SubTaskMessageId { get; set; }
        public string CallIdStatusLog { get; set; }
        public SubTaskStatusTypes Status { get; set; }
        public string ExceptionLog { get; set; } = null;
        public int NumberOfRetrys { get; set; } = 0;
        public DateTime CompletedOnUTC { get; set; }
        
        [Timestamp]
        public byte[] RowVersion { get; set; }
        public string TaskName { get;  set; }
    }
}
