const BASEURL = "http://192.168.100.66:8080";

export const urls = {
  BASEURL:"http://192.168.100.66:8080",
  AUTHENTICATE:`${BASEURL}/accounts/authenticate`,
  REGISTER_USER:`${BASEURL}/accounts/register`,
  VERIFY_ACCOUNT:`${BASEURL}/accounts/verify-account`,
  RESEND_VERIFICATION_TOKEN:`${BASEURL}/accounts/resend-validation-token`,
  FORGET_PASSWORD:`${BASEURL}/accounts/forgot-password`,
  RESET_PASSWORD:`${BASEURL}/accounts/reset-password`,
  CHANGE_PASSWORD:`${BASEURL}/accounts/change-password`,
  REFRESH_TOKEN:`${BASEURL}/accounts/refresh-token`,
  COUPONS_USER:`${BASEURL}/coupon/available-coupons`,
  COUPON_DETAIL:`${BASEURL}/coupon/detail`,
  COUPON_ACTIVATE:`${BASEURL}/coupon/activate-coupon`
  
};
