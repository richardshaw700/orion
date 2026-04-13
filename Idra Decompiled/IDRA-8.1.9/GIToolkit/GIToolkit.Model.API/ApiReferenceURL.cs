using System;
using System.Runtime.CompilerServices;
using GIToolkit.Model.Dtos.Contacts;
using GIToolkit.Model.Dtos.SimulatorDtos;
using GIToolkit.Model.Dtos.UserDtos;
using GIToolkit.Services;
using Golfin.Dtos;
using P3NBy0oT7wIBhs7JVn;
using U4yoVEpfEeOhjCsFXj;
using xvPCPAE495dWC1pA5M;

namespace GIToolkit.Model.API;

public class ApiReferenceURL
{
	public static string GetUserNameExistUrl(string userName)
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(13502) + userName;
	}

	public static string GetEmailExistUrl(string email)
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(13554) + email;
	}

	public static string GetCardExistUrl(string cardNumber)
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(13600) + cardNumber;
	}

	public static string GetActivateCardUrl(string userId)
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(13644) + userId;
	}

	public static string GetForgotPasswordUrl(string email, SupportedCulture? webBrowserCulture)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 2);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13694));
		defaultInterpolatedStringHandler.AppendFormatted(email);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(webBrowserCulture);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetResetPasswordUrl()
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(13754);
	}

	public static string GetGenerateTemporaryPasswordUrl(string UsernameOrEmail)
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(13804) + UsernameOrEmail;
	}

	public static string GetRegisterUrl()
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(13880);
	}

	public static string GetLoginUrl()
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(13920);
	}

	public static string GetLoginWithCardNumberUrl()
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(13954);
	}

	public static string GetIsServerOnUrl()
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(14012);
	}

	public static string GetEditRolesUrl(string userNameOrEmail)
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(14058) + userNameOrEmail;
	}

	public static string GetLiteSitesUrl()
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(14104);
	}

	public static string GetLiteSitesForProfileUrl()
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(14150);
	}

	public static string GetSiteUrl(int id)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(14202));
		defaultInterpolatedStringHandler.AppendFormatted(id);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetSiteStatistic(int id)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 1);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(14226));
		defaultInterpolatedStringHandler.AppendFormatted(id);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetSitesForAdminSettingsUrl()
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(14278);
	}

	public static string GetUpdateSiteUrl(int siteId)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(14202));
		defaultInterpolatedStringHandler.AppendFormatted(siteId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetNewSiteUrl()
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(14312);
	}

	public static string GetNewFeeScheduleUrl()
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(14334);
	}

	public static string GetUsersUrl(UserListFilter filters)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(39, 3);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(14370));
		defaultInterpolatedStringHandler.AppendFormatted(filters.FirstName);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(14416));
		defaultInterpolatedStringHandler.AppendFormatted(filters.LastName);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(14440));
		defaultInterpolatedStringHandler.AppendFormatted(filters.SiteId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetMembersAndContactsUrl(UserListFilter filters)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(52, 3);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(14460));
		defaultInterpolatedStringHandler.AppendFormatted(filters.FirstName);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(14416));
		defaultInterpolatedStringHandler.AppendFormatted(filters.LastName);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(14440));
		defaultInterpolatedStringHandler.AppendFormatted(filters.SiteId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetUserUrl(string id)
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(14532) + id;
	}

	public static string GetDeleteUserUrl(string id)
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(14532) + id;
	}

	public static string GetUsersByRoleUrl(string role)
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(14558) + role;
	}

	public static string GetUserByRoleForManagementUrl(string role)
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(14608) + role;
	}

	public static string GetUserByRoleForManagementUrl(string role, int siteId)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 2);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(14608));
		defaultInterpolatedStringHandler.AppendFormatted(role);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(siteId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetUserByStringUrl(string userNameOrEmail)
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(14684) + userNameOrEmail;
	}

	public static string GetUserByCardNumberUrl(string cardNumber)
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(14742) + cardNumber;
	}

	public static string GetUserByCardNumberWithinSiteUrl(string cardNumber, int siteId)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(42, 2);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(14808));
		defaultInterpolatedStringHandler.AppendFormatted(cardNumber);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(siteId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetUpdateUserUrl(string id)
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(14894) + id;
	}

	public static string GetUpdateStaffUrl(string id)
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(14942) + id;
	}

	public static string GetChangePasswordUrl(string userId)
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(14992) + userId;
	}

	public static string GetVerifyCardNumberUrl(string cardNumber)
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(15048) + cardNumber;
	}

	public static string GetAddCardTransactionUrl(string userId)
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(15108) + userId;
	}

	public static string GetPromotionsUrl()
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(15154);
	}

	public static string GetPromotionsUrl(int siteId)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(34, 1);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(15186));
		defaultInterpolatedStringHandler.AppendFormatted(siteId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetNewPromotionUrl()
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(15154);
	}

	public static string GetDeletePromoUrl(int id)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 1);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(15258));
		defaultInterpolatedStringHandler.AppendFormatted(id);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetUpdatePromotionUrl(int id)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 1);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(15258));
		defaultInterpolatedStringHandler.AppendFormatted(id);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetSiteFeeScheduleUrl(int siteId)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(15292));
		defaultInterpolatedStringHandler.AppendFormatted(siteId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetChangeFeeScheduleRateUrl()
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(14334);
	}

	public static string GetTodaySalesUrl(int siteId, TimeSpan offset)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(34, 2);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(15330));
		defaultInterpolatedStringHandler.AppendFormatted(siteId);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(offset);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetYesterdaySalesUrl(int siteId)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 1);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(15400));
		defaultInterpolatedStringHandler.AppendFormatted(siteId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetThisWeekSales(int siteId)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 1);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(15478));
		defaultInterpolatedStringHandler.AppendFormatted(siteId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetLastWeekSales(int siteId)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 1);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(15554));
		defaultInterpolatedStringHandler.AppendFormatted(siteId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetLastMonthSalesUrl(int siteId)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 1);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(15630));
		defaultInterpolatedStringHandler.AppendFormatted(siteId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetThisMonthSalesUrl(int siteId)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 1);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(15708));
		defaultInterpolatedStringHandler.AppendFormatted(siteId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetDaySalesUrl(int siteId, int year, int month, int day)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(34, 4);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(15786));
		defaultInterpolatedStringHandler.AppendFormatted(siteId);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(year);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(month);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(day);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetWeeklySalesUrl(int siteId, int year, int month, int day)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 4);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(15852));
		defaultInterpolatedStringHandler.AppendFormatted(siteId);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(year);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(month);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(day);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetMonthlySalesUrl(int siteId, int month)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 2);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(15922));
		defaultInterpolatedStringHandler.AppendFormatted(siteId);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(month);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetBetweenTwoDateUrl(int siteId, int startDateYear, int startDateMonth, int startDateDay, int endDateYear, int endDateMonth, int endDateDay)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(41, 7);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(15996));
		defaultInterpolatedStringHandler.AppendFormatted(siteId);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(startDateYear);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(startDateMonth);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(startDateDay);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(endDateYear);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(endDateMonth);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(endDateDay);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetPlayerInvoicesUrl(int rentalInvoiceId)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 1);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(16070));
		defaultInterpolatedStringHandler.AppendFormatted(rentalInvoiceId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetAppointmentsUrl()
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(16144);
	}

	public static string GetAppointmentsUrl(AppointmentListFilter filters)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(45, 2);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(16180));
		defaultInterpolatedStringHandler.AppendFormatted(filters.SiteId);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(16254));
		defaultInterpolatedStringHandler.AppendFormatted(filters.FromDate);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetAppointmentsBySiteUrl(int siteId)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 1);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(16278));
		defaultInterpolatedStringHandler.AppendFormatted(siteId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetAppointmentsBySiteDateUrl(int siteId, DateTime date)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 2);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(16278));
		defaultInterpolatedStringHandler.AppendFormatted(siteId);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(date, so95DAFNMfktfjp4Dm.An6v7kuCGg(16330));
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetSimulatorsUrl(SimulatorListFilter filters)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(16336));
		defaultInterpolatedStringHandler.AppendFormatted(filters.SiteId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetSimulatorsBySiteUrl(int siteId)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(16384));
		defaultInterpolatedStringHandler.AppendFormatted(siteId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetSimulatorForRemote(string simId)
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(16432) + simId;
	}

	public static string GetAppointmentRecurrence(int appointmentRecurrenceId)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 1);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(16510));
		defaultInterpolatedStringHandler.AppendFormatted(appointmentRecurrenceId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetAppointmentsByDateUrl(int siteId, DateTime date)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 2);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(16576));
		defaultInterpolatedStringHandler.AppendFormatted(siteId);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(date, so95DAFNMfktfjp4Dm.An6v7kuCGg(16330));
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetCreateAppointmentUrl()
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(16144);
	}

	public static string GetAddNewAppointmentBySimUrl(string simId)
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(16636) + simId;
	}

	public static string GetUpdateAppointmentUrl(int id)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(16686));
		defaultInterpolatedStringHandler.AppendFormatted(id);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetAttachInvoiceToAppointment(int appointmentId, int invoiceId)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 2);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(16724));
		defaultInterpolatedStringHandler.AppendFormatted(appointmentId);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(invoiceId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetSimulatorsAppointmentBySiteDate(int siteId, DateTime date)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(34, 2);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(16790));
		defaultInterpolatedStringHandler.AppendFormatted(siteId);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(date, so95DAFNMfktfjp4Dm.An6v7kuCGg(16860));
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetAppointmentAvailabilityUrl(int siteId, DateTime startDate, int durationHour, int durationMin)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 4);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(16866));
		defaultInterpolatedStringHandler.AppendFormatted(siteId);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(startDate, so95DAFNMfktfjp4Dm.An6v7kuCGg(16860));
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(durationHour);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(durationMin);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetDeleteAppointmentUrl(int id, SupportedCulture? webBrowserCulture)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 2);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(16686));
		defaultInterpolatedStringHandler.AppendFormatted(id);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(webBrowserCulture);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetSiteReservationSettingBySiteUrl(int siteId)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(41, 1);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(16936));
		defaultInterpolatedStringHandler.AppendFormatted(siteId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetSiteWeekOpeningHoursUrl(int siteId)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(39, 1);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(17022));
		defaultInterpolatedStringHandler.AppendFormatted(siteId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetUpdateOpeningHourUrl(int id)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(17104));
		defaultInterpolatedStringHandler.AppendFormatted(id);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetUpdateReservationSettingsUrl(int id)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 1);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(17152));
		defaultInterpolatedStringHandler.AppendFormatted(id);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetSiteWebSettingBySiteUrl(int siteId)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(17212));
		defaultInterpolatedStringHandler.AppendFormatted(siteId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetUpdateWebSettingsUrl(int id)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(17212));
		defaultInterpolatedStringHandler.AppendFormatted(id);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetAppointmentAvailabilityBySimUrl(int siteId, DateTime startDate, int durationHour, int durationMin, string simId)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 5);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(16866));
		defaultInterpolatedStringHandler.AppendFormatted(siteId);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(startDate, so95DAFNMfktfjp4Dm.An6v7kuCGg(16860));
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(durationHour);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(durationMin);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(simId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetHasAppointmentConflictUrl(int siteId, DateTime startDate, DateTime endDate, int day, DateTime? teeTime, int durationHour, int durationMin, string simId, int appointmentId)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 9);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(17256));
		defaultInterpolatedStringHandler.AppendFormatted(siteId);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(startDate, so95DAFNMfktfjp4Dm.An6v7kuCGg(16860));
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(endDate, so95DAFNMfktfjp4Dm.An6v7kuCGg(16860));
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(day);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(teeTime, so95DAFNMfktfjp4Dm.An6v7kuCGg(16860));
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(durationHour);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(durationMin);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(simId);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(appointmentId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetSearchAppointment(string idOrTitle, int siteId)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 2);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(17318));
		defaultInterpolatedStringHandler.AppendFormatted(idOrTitle);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(siteId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetUpdateSimulatorUrl(string simId)
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(17392) + simId;
	}

	public static string GetUpdateSimulatorStateUrl(string simId, bool isAvailable)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(38, 2);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(17426));
		defaultInterpolatedStringHandler.AppendFormatted(simId);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(isAvailable);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetMemberAppointments(string userId)
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(17504) + userId;
	}

	public static string GetLiteSitesForReservationUrl()
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(17560);
	}

	public static string GetAddRecurrentAppointmentUrl(string simId)
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(17620) + simId;
	}

	public static string GetDeleteAppointmentSeriesUrl(int id, SupportedCulture? webBrowserCulture)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 2);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(17688));
		defaultInterpolatedStringHandler.AppendFormatted(id);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(webBrowserCulture);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetDeleteAppointmentSeriesUrl()
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(17740);
	}

	public static string CreateNotificationRecipient()
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(17790);
	}

	public static string GetDeleteNotificationRecipientUrl(int id)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 1);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(17846));
		defaultInterpolatedStringHandler.AppendFormatted(id);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetAppointmentHistoryBySite(int siteId, DateTime dateStart, DateTime dateEnd)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(44, 3);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(17904));
		defaultInterpolatedStringHandler.AppendFormatted(siteId);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(dateStart, so95DAFNMfktfjp4Dm.An6v7kuCGg(16860));
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(dateEnd, so95DAFNMfktfjp4Dm.An6v7kuCGg(16860));
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetAppointmentHistoryByReservation(int reservationId)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(49, 1);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(17992));
		defaultInterpolatedStringHandler.AppendFormatted(reservationId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetUpdateUserSiteId(string userId, int newSiteId)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(18094));
		defaultInterpolatedStringHandler.AppendFormatted(userId);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(newSiteId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetUpdateMemberUrl(string userId)
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(18142) + userId;
	}

	public static string GetDefaultPromotions()
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(18194);
	}

	public static string GetChangeFeeScheduleRateUrl(int id, decimal rate)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 2);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(15292));
		defaultInterpolatedStringHandler.AppendFormatted(id);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(rate);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetAppointmentFromSimTimeUrl(string simulatorId, DateTime now)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(44, 2);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(18252));
		defaultInterpolatedStringHandler.AppendFormatted(simulatorId);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(13748));
		defaultInterpolatedStringHandler.AppendFormatted(now, so95DAFNMfktfjp4Dm.An6v7kuCGg(16330));
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string UpdateSimulatorManagementUrl(string id)
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(18342) + id;
	}

	public static string RemoveSimulatorManagementUrl(string id)
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(18408) + id;
	}

	public static string UpdateSimulatorManagementrUrl()
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(18488);
	}

	public static string GetSimulatorsManagementUrl()
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(18488);
	}

	public static string GetSimulatorExist(string simId)
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(17392) + simId;
	}

	public static string GetIoTDeviceBySimulator(string simulatorID)
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(18552) + simulatorID;
	}

	public static string GetUnPairedIoTDevicesUrl()
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(18610);
	}

	public static string GetPutIotDeviceUrl(int id)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 1);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(18660));
		defaultInterpolatedStringHandler.AppendFormatted(id);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string PostNewDeviceOnAzureHubUrl(string azureDeviceID)
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(18694) + azureDeviceID;
	}

	public static string GetIoTDeviceStatusByAzureDeviceID(string azureDeviceID)
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(18770) + azureDeviceID;
	}

	public static string GetIoTDeviceStatusBySimulatorID(string simulatorId)
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(18848) + simulatorId;
	}

	public static string GetIoTDeviceStatus(int DeviceID)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 1);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(18922));
		defaultInterpolatedStringHandler.AppendFormatted(DeviceID);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetIoTDevice(string DeviceID)
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(18660) + DeviceID;
	}

	public static string GetIoTDeviceStatus(string DeviceID)
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(18968) + DeviceID;
	}

	public static string GetIoTDeviceBySim(string simulatorID)
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(18552) + simulatorID;
	}

	public static string GetConnectivityDevice(string DeviceID)
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(19036) + DeviceID;
	}

	public static string RegisterRemoteSaleUrl()
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(19096);
	}

	public static string UdpateInvoiceUrl(int rentalInvoiceId)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(33, 1);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(19162));
		defaultInterpolatedStringHandler.AppendFormatted(rentalInvoiceId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string PostNotifySim(string DeviceID)
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(19232) + DeviceID;
	}

	public static string StartRentalSession()
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(19280);
	}

	public static string ActivateRentalSession()
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(19348);
	}

	public static string PauseRentalSession()
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(19422);
	}

	public static string ResumeRentalSession()
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(19490);
	}

	public static string StopRentalSession()
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(19560);
	}

	public static string CreateSimulatorManagementUrl()
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(18488);
	}

	public static string TransfertSimulatorReservation(string simGiverId, string simReceiverId)
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(18342) + simGiverId + so95DAFNMfktfjp4Dm.An6v7kuCGg(13748) + simReceiverId;
	}

	public static string GetActiveAppointmentSimulatorUrl(int id)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 1);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(19626));
		defaultInterpolatedStringHandler.AppendFormatted(id);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetActiveAppointmentSimulatorFromSimIdUrl(string simulatorId)
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(19694) + simulatorId;
	}

	public static string GetActiveAppointmentSimulatorFromAppointmentIdUrl(int appointmentId)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(48, 1);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(19778));
		defaultInterpolatedStringHandler.AppendFormatted(appointmentId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetActiveAppointmentSimulatorFromRentalSessionIdUrl(int rentalSessionId)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(50, 1);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(19878));
		defaultInterpolatedStringHandler.AppendFormatted(rentalSessionId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetUpdateReleaseNotesUrl()
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(19982);
	}

	public static string GetAllReleaseNotesUrl()
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(20032);
	}

	public static string GetHasCurrentUserSeenLatestReleaseNote()
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(20082);
	}

	public static string GetNotifyNewReleaseNote()
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(20176);
	}

	public static string MarkNewReleaseNoteViewByCurrentUser()
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(20254);
	}

	public static string GetRentalInvoiceForRemote(int invoiceId)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 1);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(20362));
		defaultInterpolatedStringHandler.AppendFormatted(invoiceId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetBaseContactUrl()
	{
		return so95DAFNMfktfjp4Dm.An6v7kuCGg(20418);
	}

	public static string GetUpdateContactUrl(int contactId)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(20446));
		defaultInterpolatedStringHandler.AppendFormatted(contactId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetContactsUrl(ContactListFilter filters)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 2);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(20476));
		defaultInterpolatedStringHandler.AppendFormatted(filters.CurrentPage);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(20530));
		defaultInterpolatedStringHandler.AppendFormatted(filters.PageSize);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public static string GetBaseSimulatorAvailabilityUrl(SimulatorAvailabilityDto dto)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(157, 7);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(20554));
		defaultInterpolatedStringHandler.AppendFormatted(dto.SiteId);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(20668));
		defaultInterpolatedStringHandler.AppendFormatted(dto.DurationHour);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(20700));
		defaultInterpolatedStringHandler.AppendFormatted(dto.DurationMinute);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(20736));
		defaultInterpolatedStringHandler.AppendFormatted(dto.CurrentAppointmentId);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(20784));
		defaultInterpolatedStringHandler.AppendFormatted(dto.SimulatorId);
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(20814));
		defaultInterpolatedStringHandler.AppendFormatted(dto.StartDate, so95DAFNMfktfjp4Dm.An6v7kuCGg(16860));
		defaultInterpolatedStringHandler.AppendLiteral(so95DAFNMfktfjp4Dm.An6v7kuCGg(20840));
		defaultInterpolatedStringHandler.AppendFormatted(dto.ShouldReturnOutsideHours);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public ApiReferenceURL()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
	}
}
