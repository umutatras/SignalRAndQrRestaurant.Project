using SignalR.DtoLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.DeskDtos;

public class DeskUpdateDto:IUpdateDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool Status { get; set; }
}
