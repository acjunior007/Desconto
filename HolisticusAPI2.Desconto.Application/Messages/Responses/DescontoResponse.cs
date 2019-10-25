using AzimuteLib.HTTPBase;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace HolisticusAPI2.Desconto.Application.Messages.Responses
{
    public class DescontoResponse : BaseResponse
    {
        [DataMember(Name = "desconto")]
        public bool IsContemDesconto { get; set; }
    }
}
