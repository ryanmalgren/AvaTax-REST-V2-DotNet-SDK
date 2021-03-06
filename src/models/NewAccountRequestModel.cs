using System;
using System.Collections.Generic;
using Newtonsoft.Json;

/*
 * AvaTax API Client Library
 *
 * (c) 2004-2017 Avalara, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author Ted Spence
 * @author Zhenya Frolov
 */

namespace Avalara.AvaTax.RestClient
{
    /// <summary>
    /// Represents a request for a new account with Avalara for a new subscriber.
    /// Contains information about the account requested and the rate plan selected.
    /// </summary>
    public class NewAccountRequestModel
    {
        /// <summary>
        /// Offer with which the partner account needs to be created
        /// </summary>
        public String offer { get; set; }

        /// <summary>
        /// The date on which the account should take effect. If null, defaults to today.
        /// </summary>
        public DateTime? effectiveDate { get; set; }

        /// <summary>
        /// The date on which the account should expire. If null, defaults to a 90-day trial account.
        /// </summary>
        public DateTime? endDate { get; set; }

        /// <summary>
        /// Account Name
        /// </summary>
        public String accountName { get; set; }

        /// <summary>
        /// Website of the partner account being created
        /// </summary>
        public String website { get; set; }

        /// <summary>
        /// First Name of the primary contact person for this account
        /// </summary>
        public String firstName { get; set; }

        /// <summary>
        /// Last Name of the primary contact person for this account
        /// </summary>
        public String lastName { get; set; }

        /// <summary>
        /// Title of the primary contact person for this account
        /// </summary>
        public String title { get; set; }

        /// <summary>
        /// Phone number of the primary contact person for this account
        /// </summary>
        public String phoneNumber { get; set; }

        /// <summary>
        /// Email of the primary contact person for this account
        /// </summary>
        public String email { get; set; }

        /// <summary>
        /// If no password is supplied, an a tempoarary password is generated by the system and emailed to the user. The user will 
        /// be challenged to change this password upon logging in to the Admin Console. If supplied, will be the set password for 
        /// the default created user, and the user will not be challenged to change their password upon login to the Admin Console.
        /// </summary>
        public String userPassword { get; set; }

        /// <summary>
        /// Normal - If a welcome email needs to be generated for the user.
        /// Suppressed - If no welcome email needs to be generated for the user.
        /// Custom - If a custom welcome email needs to be generated for the user.
        /// </summary>
        public WelcomeEmail? welcomeEmail { get; set; }

        /// <summary>
        /// Address information of the account being created.
        /// </summary>
        public CompanyAddress companyAddress { get; set; }

        /// <summary>
        /// Company code to be assigned to the company created for this account.
        /// </summary>
        public String companyCode { get; set; }

        /// <summary>
        /// Properties of the primary contact person for this account
        /// </summary>
        public List<String> properties { get; set; }

        /// <summary>
        /// Set this to true if and only if the owner of the newly created account accepts Avalara's terms and conditions for your account.
        /// </summary>
        public Boolean? acceptAvalaraTermsAndConditions { get; set; }

        /// <summary>
        /// Set this to true if and only if the owner of the newly created account has fully read Avalara's terms and conditions for your account.
        /// </summary>
        public Boolean? haveReadAvalaraTermsAndConditions { get; set; }


        /// <summary>
        /// Convert this object to a JSON string of itself
        /// </summary>
        /// <returns>A JSON string of this object</returns>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings() { Formatting = Formatting.Indented });
        }
    }
}
