using System.Text.Json.Serialization;

namespace OCPI.Contracts;

public class OcpiCancelReservationCommand
{
    /// <summary>
    /// URL that the
    /// <see cref="OcpiCommandResult">CommandResult</see>
    /// POST should be sent to.
    /// This URL might contain a unique ID to be able to distinguish
    /// between
    /// <see cref="OcpiCancelReservationCommand">CancelReservation</see>
    /// requests.
    /// </summary>
    [JsonPropertyName("response_url")]
    public string? ResponseUrl { get; set; }

    /// <summary>
    /// Reservation id, unique for this reservation.
    /// If the Charge Point already has a reservation that matches this reservationId
    /// the Charge Point will replace the reservation.
    /// </summary>
    [JsonPropertyName("reservation_id")]
    public string? ReservationId { get; set; }
}
