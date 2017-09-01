﻿using AutoMapper;
using System.Collections.Generic;

namespace Sia.Connectors.Tickets
{
    public abstract class Converter<TTicket>
    {
        public abstract ICollection<Data.Incidents.Models.Event> ExtractEvents(TTicket ticket);

        public virtual Domain.Incident AssembleIncident(Data.Incidents.Models.Incident databaseRecord, TTicket ticket)
        {
            if(ticket != null)
            {
                foreach (var ev in ExtractEvents(ticket))
                {
                    databaseRecord.Events.Add(ev);
                }
            }
            return Mapper.Map<Domain.Incident>(databaseRecord);
        }
    }
}
