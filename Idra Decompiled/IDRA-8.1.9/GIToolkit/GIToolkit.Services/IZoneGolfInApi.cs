using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using GIToolkit.Model.Dtos.AppointmentDtos;
using GIToolkit.Model.Dtos.Contacts;
using GIToolkit.Model.Dtos.SimulatorDtos;
using GIToolkit.Model.Dtos.UserDtos;
using GIToolkit.Model.Paging;
using Golfin.Dtos;

namespace GIToolkit.Services;

public interface IZoneGolfInApi
{
	Task<bool> ActivateCard(string userId, ActivateCardDto tempUserForUpdateDto);

	Task<bool> AddCardTransaction(string userId, NewCardTransactionDto newCardTxDto);

	Task<AppointmentDto> AddNewAppointment(AppointmentForCreationDto appointment);

	Task<AppointmentDto> AddNewAppointmentBySim(string simId, AppointmentForCreationDto appointment);

	Task<bool> AddRecurrentAppointment(string simId, AppointmentReccurenceForCreationDto appointment);

	Task<IEnumerable<SalesReportDto>> BetweenTwoDate(int siteId, DateTime startDate, DateTime endDate);

	Task<bool> CardExist(string cardNumber);

	Task<bool> ChangeFeeScheduleRate(HourRateToUpdateDto hourRateDtoToUpdate);

	Task<bool> ChangePassword(string userId, ChangePasswordDto changePasswordDto);

	void ChangeCurrentCulture(SupportedCulture newCulture);

	string GetCurrentAPICulture();

	Task<SimulatorDto> CreateNewSimulator(SimulatorForCreationDto newSim);

	Task<NotificationRecipientDto> CreateNotificationRecipient(NotificationRecipientForCreationDto notificationRecipientsDto);

	Task<bool> DeleteAppointment(int id, SupportedCulture? webBrowserCulture = null);

	Task<bool> DeleteAppointmentSeries(int id, SupportedCulture? webBrowserCulture = null);

	Task<bool> DeleteAppointmentSeries(AppointmentRecurrenceForDeleteDto recurrenceToDelete);

	Task<bool> DeleteNotificationRecipient(int id);

	Task<bool> DeletePromo(int id);

	Task<bool> DeleteUser(string id);

	Task<string[]> EditRoles(string userNameOrEmail, string[] roles);

	Task<bool> EmailExist(string email);

	Task<bool> ForgotPassword(string email, SupportedCulture? webBrowserCulture = null);

	Task<List<UserForManagementDto>> GetAllEmployees();

	Task<IEnumerable<SiteLiteDto>> GetAllLiteSites();

	string GetApiUrl();

	Task<IEnumerable<DateTime?>> GetAppointmentAvailability(int siteId, DateTime startDate, int durationHour, int durationMin);

	Task<IEnumerable<DateTime?>> GetAppointmentAvailabilityBySim(int siteId, DateTime startDate, int durationHour, int durationMin, string simId);

	Task<IEnumerable<AppointmentHistoryDto>> GetAppointmentHistoryBySite(int siteId, DateTime dateStart, DateTime dateEnd);

	Task<IEnumerable<AppointmentHistoryDto>> GetAppointmentHistoryByReservation(int reservationId);

	Task<AppointmentRecurrenceDto> GetAppointmentRecurrence(int appointmentRecurrenceId);

	Task<IEnumerable<AppointmentDto>> GetAppointments();

	Task<IEnumerable<AppointmentDto>> GetAppointments(AppointmentListFilter filters);

	Task<IEnumerable<AppointmentDto>> GetAppointmentsBySite(int siteId);

	Task<IEnumerable<AppointmentDto>> GetAppointmentsBySite(int siteId, DateTime date);

	Task<AppointmentDto> GetAppointmentFromSimTime(string simulatorId, DateTime now);

	Task<AppointmentDto> SearchAppointment(string idOrTitle, int siteId);

	Task<IEnumerable<SalesReportDto>> GetDaySales(int siteId, DateTime time);

	Task<IEnumerable<PromotionDto>> GetDefaultPromotions();

	Task<IEnumerable<AppointmentDto>> GetHasAppointmentConflict(int siteId, DateTime startDate, DateTime endDate, int day, DateTime? teeTime, int durationHour, int durationMin, string simId, int appointmentId);

	HttpClient GetHttpContext();

	Task<bool> AttachInvoiceToAppointment(int appointmentId, int invoiceId);

	Task<RentalInvoiceDto> GetRentalInvoice(int invoiceId);

	Task<ActiveAppointmentSimulatorDto> GetActiveAppointmentSimulator(int id);

	Task<ActiveAppointmentSimulatorDto> GetActiveAppointmentSimulatorFromSimId(string simulatorId);

	Task<ActiveAppointmentSimulatorDto> GetActiveAppointmentSimulatorFromAppointmentId(int appointmentId);

	Task<ActiveAppointmentSimulatorDto> GetActiveAppointmentSimulatorFromRentalSessionId(int rentalSessionId);

	Task<bool> UpdateRentalInvoice(int id, NewRentalInvoiceDto rentalInvoiceForUpdate);

	Task<NewRentalInvoiceDto> GetRentalInvoiceForRemote(int invoiceId);

	Task<IEnumerable<SalesReportDto>> GetLastMonthSales(int siteId);

	Task<IEnumerable<SalesReportDto>> GetLastWeekSales(int siteId);

	Task<IEnumerable<SiteLiteDto>> GetLiteSites();

	Task<IEnumerable<SiteLiteDto>> GetLiteSitesForReservation();

	Task<IEnumerable<SiteLiteForProfileDto>> GetLiteSitesForProfile();

	Task<List<AppointmentDto>> GetMemberAppointments(string userId);

	Task<IEnumerable<SalesReportDto>> GetMonthlySales(int siteId, int month);

	Task<IEnumerable<PlayerInvoiceSalesReportDto>> GetPlayerInvoices(int rentalInvoiceId);

	Task<bool> UdpateInvoice(int rentalInvoiceId, UpdateInvoiceDto updatedInvoice);

	Task<RentalInvoiceDto> RegisterRemoteSale(RegisterSaleDto registerSaleDto);

	Task<IEnumerable<PromotionDto>> GetPromotions();

	Task<IEnumerable<PromotionDto>> GetPromotions(int siteId);

	Task<SimulatorDto> GetSimulatorExist(string simId);

	Task<SimulatorDto> GetSimulatorForRemote(string simId);

	Task<IoTDeviceDto> GetIoTDeviceBySimulator(string simulatorID);

	Task<IoTDeviceDto> GetIoTDevice(string DeviceID);

	Task<IEnumerable<IoTDeviceDto>> GetUnPairedIoTDevices();

	Task<IoTDeviceStatusDto> GetIoTDeviceStatus(int DeviceID);

	Task<IoTDeviceStatusDto> GetIoTDeviceStatusBySimulatorID(string simulatorId);

	Task<IoTDeviceStatusDto> GetIoTDeviceStatusByAzureDeviceID(string azureDeviceID);

	Task<bool> CheckConnection(string deviceID);

	Task<bool> NotifyIOTDevice(string deviceID);

	Task<bool> PutIotDevice(int id, IoTDeviceForUpdateDto ioTDeviceForUpdateDto);

	Task<bool> StartRentalSession(RentalActionModifyDto rentalActionModifyDto);

	Task<bool> ActivateRentalSession(RentalActionModifyDto rentalActionModifyDto);

	Task<bool> PauseRentalSession(RentalActionModifyDto rentalActionModifyDto);

	Task<bool> ResumeRentalSession(RentalActionModifyDto rentalActionModifyDto);

	Task<bool> StopRentalSession(RentalActionModifyDto rentalActionModifyDto);

	Task<IEnumerable<SimulatorDto>> GetSimulatorsAppointmentBySiteDate(int siteId, DateTime date);

	Task<IEnumerable<SimulatorDto>> GetSimulatorsBySite(int siteId);

	Task<IoTDeviceDto> NewIotDevice(string azureDeviceId);

	Task<SimulatorRemoteManagementPostDto> NewSimulatorManagement(SimulatorRemoteManagementPostDto simDto);

	Task<bool> TransfertSimulatorReservation(string simGiverId, string simReceiverId);

	Task<IEnumerable<SimulatorRemoteManagementDto>> GetSimulatorsManagement();

	Task<SiteDto> GetSite(int siteId);

	Task<FeeScheduleDto> GetSiteFeeSchedule(int siteId);

	Task<SiteReservationSettingDto> GetSiteReservationSettingBySite(int siteId);

	Task<IEnumerable<SiteAdminSettingsDto>> GetSitesForAdminSettings();

	Task<SiteStatistic> GetSiteStatistic(int siteId);

	Task<List<DayOpeningHoursDto>> GetSiteWeekOpeningHours(int siteId);

	Task<IEnumerable<SalesReportDto>> GetThisMonthSales(int siteId);

	Task<IEnumerable<SalesReportDto>> GetThisWeekSales(int siteId);

	Task<IEnumerable<SalesReportDto>> GetTodaySales(int siteId, TimeSpan offset);

	Task<UserDto> GetUser(string id);

	Task<UserDto> GetUserByCardNumber(string cardNumber);

	Task<UserDto> GetUserByCardNumberWithinSite(string cardNumber, int siteId);

	Task<IEnumerable<UserForManagementDto>> GetUserByRoleForManagement(string role);

	Task<IEnumerable<UserForManagementDto>> GetUserByRoleForManagement(string role, int siteId);

	Task<UserDto> GetUserByString(string userNameOrEmail);

	Task<IEnumerable<UserDto>> GetUsers(UserListFilter filters);

	Task<IEnumerable<SiteUserDto>> GetMembersAndContacts(UserListFilter filters);

	Task<IEnumerable<SalesReportDto>> GetWeeklySales(int siteId, DateTime time);

	Task<IEnumerable<SalesReportDto>> GetYesterdaySales(int siteId);

	Task<bool> IsServerOn();

	Task<T> Login<T>(UserForLoginDto userForLoginDto) where T : class;

	Task<LoggedInfo> LoginWithCardNumber(UserForLoginFromCardNumberDto userInfo);

	Task<FeeScheduleDto> NewFeeSchedule(FeeScheduleForCreationDto feeScheduleDto);

	Task<PromotionDto> NewPromotion(PromotionForCreationDto promoDto);

	Task<SiteDto> NewSite(SiteForCreationDto siteDto);

	Task<UserDto> Register(UserForRegisterDto userForRegisterDto);

	Task<RentalInvoiceDto> RegisterNewSessionSale(NewSessionSalesDto newSessionSales);

	Task<bool> ResetPassword(ResetPasswordDto model);

	Task<TempPasswordDto> GenerateTemporaryPassword(string EmailOrUserName);

	void SetApiToUse(AvailableAPI api);

	void SetApiToUse(string apiUrl);

	void SetAuthorization(string tokenStr);

	Task<bool> UpdateAppointment(int id, AppointmentForUpdateDto appointmentToUpdate);

	Task<bool> UpdateMember(string userId, UserManagementUpdateDto userForUpdateDto);

	Task<bool> UpdateOpeningHour(int id, DayOpeningHoursForUpdateDto dayToUpdate);

	Task<bool> UpdatePromotion(int id, PromotionForUpdateDto promoForUpdate);

	Task<bool> UpdateReservationSettings(int id, SiteReservationSettingForUpdateDto siteReservationToUpdate);

	Task<bool> UpdateWebSettings(int id, SiteWebSettingForUpdateDto siteWebToUpdate);

	Task<bool> UpdateSimulator(string simId, SimulatorForUpdateDto simulatorForUpdateDto);

	Task<bool> UpdateSimulatorState(string simId, bool isAvailable);

	Task<bool> RemoveSimulatorManagement(string id);

	Task<bool> UpdateSimulatorManagement(string id, SimulatorRemoteManagementPutDto simForUpdate);

	Task<bool> UpdateSite(int siteId, SiteForUpdateDto siteForUpdateDto);

	Task<UserDto> UpdateTestMember(string cardNumber, decimal defaultHourlyRate, UserUnitTestDto model);

	Task<bool> UpdateUser(string userId, UserForUpdateDto userForUpdateDto);

	Task<bool> UpdateUserSiteId(string userId, int siteId);

	Task<bool> UsernameExist(string userName);

	bool IsTokenValid(string tokenStr);

	Task<UserDto> VerifyCardNumber(string cardNumber);

	Task<SiteWebSettingDto> GetSiteWebSettingsBySite(int siteId);

	Task<bool> UpdateStaff(string staffId, StaffForUpdateDto staffForUpdateDto);

	Task<bool> UpdateReleaseNotes(IEnumerable<ReleaseNoteDto> releasesNotes);

	Task<bool> NotifyNewReleaseNote();

	Task<bool> MarkNewReleaseNoteViewByCurrentUser();

	Task<bool> HasCurrentUserSeenLatestReleaseNote();

	Task<IEnumerable<ReleaseNoteDto>> GetAllReleaseNotes();

	Task<PagedResult<ContactDto>> GetContacts(ContactListFilter filters);

	Task<ContactDto> CreateContact(CreateContactDto contact);

	Task<ContactDto> UpdateContact(ContactDto contact, int id);

	Task<bool> DeleteContact(int id);

	Task<IEnumerable<DateTime?>> GetAvailabilitiesBySim(SimulatorAvailabilityDto availabilityDto);
}
