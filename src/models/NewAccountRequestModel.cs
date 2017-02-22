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
        ///Contains information about the account requested and the rate plan selected.
    /// </summary>
    public class NewAccountRequestModel
    {
        /// <summary>
        /// The list of products to which this account would like to subscribe.
        /// </summary>
        public List<String> products { get; set; }

        /// <summary>
        /// The name of the connector that will be the primary method of access used to call the account created.
        ///For a list of available connectors, please contact your Avalara representative.
        /// </summary>
        public String connectorName { get; set; }

        /// <summary>
        /// An approved partner account can be referenced when provisioning an account, allowing a link between 
        ///the partner and the provisioned account.
        /// </summary>
        public String parentAccountNumber { get; set; }

        /// <summary>
        /// Identifies a referring partner for the assessment of referral-based commissions.
        /// </summary>
        public String referrerId { get; set; }

        /// <summary>
        /// Zuora-generated Payment ID to which the new account should be associated. For free trial accounts, an empty string is acceptable.
        /// </summary>
        public String paymentMethodId { get; set; }

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
        ///be challenged to change this password upon logging in to the Admin Console. If supplied, will be the set password for 
        ///the default created user, and the user will not be challenged to change their password upon login to the Admin Console.
        /// </summary>
        public String userPassword { get; set; }


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
