using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quickeat.Core.Enums;

public enum OrderStatus
{
    Pending,        // Just created
    Confirmed,      // Restaurant accepted
    Preparing,     // Cooking in progress
    ReadyForPickup, // Waiting for delivery person
    OnDelivery,     // Currently being delivered
    Delivered,      // Successfully delivered
    Cancelled       // Order was cancelled
}
