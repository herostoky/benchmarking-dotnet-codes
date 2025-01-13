var idsInDb =
    "429525000014830000|429525000014833000|429525000014818050|429525000014800000|429525000014800060|429525000014720000|429525000014726000|429525000014724030|429525000014734000|429525000014722000|429525000014709000|429525000014704000|429525000014695000|429525000014694000|429525000014702000|429525000014668000|429525000014573300|429525000014573250|429525000014539000|429525000014573060|429525000014594000|429525000014595000|429525000014573000|429525000014554000|429525000014554050|429525000014531000|429525000014532030|429525000014511040|429525000014511000|429525000014510000|429525000014454000|429525000014457000|429525000014456000|429525000014427100|429525000014377000|429525000014378000|429525000014340030|429525000014298940|429525000014298240|429525000014298100|429525000014299100|429525000014298600|429525000014298200|429525000014298700|429525000014298050|429525000014272060|429525000014298000|429525000014277000|429525000014271000|429525000014227000|429525000014148030|429525000014193000|429525000014192000|429525000014147000|429525000014120000|429525000014042100|429525000014074000|429525000014061000|429525000014034000|429525000013959200|429525000014001000|429525000013990140|429525000013959100|429525000013964000|429525000013989000|429525000013959040|429525000013979000|429525000013979100|429525000013962050|429525000013937000|429525000013938000|429525000013727040|429525000013715000|429525000013654100|429525000013544060|429525000013095040|429525000012233000|429525000011741440|429525000011741500"
        .Split('|');

var requestObjects = System.Text.Json.JsonSerializer.Deserialize<RequestObj[]>(
    """
    [
        {
            "Zoho.ID": 429525000014573250,
            "From": "20-Dec-2024",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Ithiel Ramaroharinosy",
            "Leavetype": "Holiday Mada",
            "Days": {
                "20-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "20-Dec-2024",
            "EmployeeId": "21",
            "ZUID": 784439171,
            "Employee.ID": 429525000008278000,
            "DateOfRequest": "13-Dec-2024",
            "Zoho_ID": 429525000014573250,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000008278000
        },
        {
            "Zoho.ID": 429525000012233000,
            "From": "07-Nov-2024",
            "Leavetype.ID": 429525000000532160,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Yves Muyters",
            "Leavetype": "Verlof - onbetaald",
            "Days": {
                "07-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "08-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "08-Nov-2024",
            "EmployeeId": "12",
            "ZUID": 714687561,
            "Employee.ID": 429525000001514300,
            "DateOfRequest": "25-Jan-2024",
            "Zoho_ID": 429525000012233000,
            "Leavetype_ID": 429525000000532160,
            "Employee_ID": 429525000001514300
        },
        {
            "Zoho.ID": 429525000013938000,
            "From": "18-Oct-2024",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Mendrika Ramiharimanitra",
            "Leavetype": "Holiday Mada",
            "Days": {
                "18-Oct-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "18-Oct-2024",
            "EmployeeId": "20",
            "ZUID": 762547585,
            "Employee.ID": 429525000006096000,
            "DateOfRequest": "08-Oct-2024",
            "Zoho_ID": 429525000013938000,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000006096000
        },
        {
            "Zoho.ID": 429525000013959040,
            "From": "07-Apr-2025",
            "Leavetype.ID": 429525000000532160,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Reason": "schoolvakantie (ardennen)",
            "Type": "UNPAID",
            "Employee": "Damiaan Peeters",
            "Leavetype": "Verlof - onbetaald",
            "Days": {
                "07-Apr-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "11-Apr-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "08-Apr-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "10-Apr-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "09-Apr-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "11-Apr-2025",
            "EmployeeId": "26",
            "ZUID": 797619148,
            "Employee.ID": 429525000009129000,
            "DateOfRequest": "15-Oct-2024",
            "Zoho_ID": 429525000013959040,
            "Leavetype_ID": 429525000000532160,
            "Employee_ID": 429525000009129000
        },
        {
            "Zoho.ID": 429525000014573300,
            "From": "07-Jan-2025",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Ithiel Ramaroharinosy",
            "Leavetype": "Holiday Mada",
            "Days": {
                "09-Jan-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "07-Jan-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "10-Jan-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "08-Jan-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "10-Jan-2025",
            "EmployeeId": "21",
            "ZUID": 784439171,
            "Employee.ID": 429525000008278000,
            "DateOfRequest": "13-Dec-2024",
            "Zoho_ID": 429525000014573300,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000008278000
        },
        {
            "Zoho.ID": 429525000014668000,
            "From": "12-Dec-2024",
            "Leavetype.ID": 429525000000532200,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "PAID",
            "Employee": "Nambinina Ratovolalao",
            "Leavetype": "Sickness",
            "Days": {
                "12-Dec-2024": {
                    "LeaveCount": "0.5",
                    "EndTime": "13:15",
                    "StartTime": "09:00",
                    "Session": 1
                }
            },
            "To": "12-Dec-2024",
            "EmployeeId": "28",
            "ZUID": 806776542,
            "Employee.ID": 429525000010013000,
            "DateOfRequest": "16-Dec-2024",
            "Zoho_ID": 429525000014668000,
            "Leavetype_ID": 429525000000532200,
            "Employee_ID": 429525000010013000
        },
        {
            "Zoho.ID": 429525000014147000,
            "From": "25-Nov-2024",
            "Leavetype.ID": 429525000000532160,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Reason": "onder voorbehoud",
            "Type": "UNPAID",
            "Employee": "Amina Fajjia",
            "Leavetype": "Verlof - onbetaald",
            "Days": {
                "28-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "25-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "27-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "26-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "28-Nov-2024",
            "EmployeeId": "HRM1",
            "ZUID": 856545530,
            "Employee.ID": 429525000013227000,
            "DateOfRequest": "30-Oct-2024",
            "Zoho_ID": 429525000014147000,
            "Leavetype_ID": 429525000000532160,
            "Employee_ID": 429525000013227000
        },
        {
            "Zoho.ID": 429525000014531000,
            "From": "13-Dec-2024",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Mendrika Ramiharimanitra",
            "Leavetype": "Holiday Mada",
            "Days": {
                "13-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "13-Dec-2024",
            "EmployeeId": "20",
            "ZUID": 762547585,
            "Employee.ID": 429525000006096000,
            "DateOfRequest": "03-Dec-2024",
            "Zoho_ID": 429525000014531000,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000006096000
        },
        {
            "Zoho.ID": 429525000014554000,
            "From": "30-Dec-2024",
            "Leavetype.ID": 429525000000532160,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Robin Van Gijseghem ",
            "Leavetype": "Verlof - onbetaald",
            "Days": {
                "01-Jan-2025": {
                    "LeaveCount": "0.0",
                    "Session": 1
                },
                "03-Jan-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "31-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "30-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "02-Jan-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "03-Jan-2025",
            "EmployeeId": "17",
            "ZUID": 738663195,
            "Employee.ID": 429525000003851000,
            "DateOfRequest": "05-Dec-2024",
            "Zoho_ID": 429525000014554000,
            "Leavetype_ID": 429525000000532160,
            "Employee_ID": 429525000003851000
        },
        {
            "Zoho.ID": 429525000014148030,
            "From": "18-Dec-2024",
            "Leavetype.ID": 429525000000532200,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "PAID",
            "Employee": "Jeroen Samyn",
            "Leavetype": "Holiday",
            "Days": {
                "18-Dec-2024": {
                    "LeaveCount": "0.5",
                    "EndTime": "17:30",
                    "StartTime": "13:15",
                    "Session": 2
                }
            },
            "To": "18-Dec-2024",
            "EmployeeId": "5",
            "ZUID": 666117247,
            "Employee.ID": 429525000000133000,
            "DateOfRequest": "06-Nov-2024",
            "Zoho_ID": 429525000014148030,
            "Leavetype_ID": 429525000000532200,
            "Employee_ID": 429525000000133000
        },
        {
            "Zoho.ID": 429525000014594000,
            "From": "16-Dec-2024",
            "Leavetype.ID": 429525000000532160,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Robin Van Gijseghem ",
            "Leavetype": "Verlof - onbetaald",
            "Days": {
                "16-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "16-Dec-2024",
            "EmployeeId": "17",
            "ZUID": 738663195,
            "Employee.ID": 429525000003851000,
            "DateOfRequest": "09-Dec-2024",
            "Zoho_ID": 429525000014594000,
            "Leavetype_ID": 429525000000532160,
            "Employee_ID": 429525000003851000
        },
        {
            "Zoho.ID": 429525000014298050,
            "From": "13-Dec-2024",
            "Leavetype.ID": 429525000000532100,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "PAID",
            "Employee": "Jeroen Samyn",
            "Leavetype": "Anciëniteitsverlof",
            "Days": {
                "13-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "13-Dec-2024",
            "EmployeeId": "5",
            "ZUID": 666117247,
            "Employee.ID": 429525000000133000,
            "DateOfRequest": "12-Nov-2024",
            "Zoho_ID": 429525000014298050,
            "Leavetype_ID": 429525000000532100,
            "Employee_ID": 429525000000133000
        },
        {
            "Zoho.ID": 429525000014272060,
            "From": "18-Nov-2024",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Anjatiana Ramalala",
            "Leavetype": "Holiday Mada",
            "Days": {
                "18-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "19-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "19-Nov-2024",
            "EmployeeId": "33",
            "ZUID": 838491050,
            "Employee.ID": 429525000011962000,
            "DateOfRequest": "12-Nov-2024",
            "Zoho_ID": 429525000014272060,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000011962000
        },
        {
            "Zoho.ID": 429525000013715000,
            "From": "18-Dec-2024",
            "Leavetype.ID": 429525000000532160,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Reason": "jaarlijkse zitting",
            "Type": "UNPAID",
            "Employee": "Damiaan Peeters",
            "Leavetype": "Verlof - onbetaald",
            "Days": {
                "18-Dec-2024": {
                    "LeaveCount": "0.5",
                    "EndTime": "13:15",
                    "StartTime": "09:00",
                    "Session": 1
                }
            },
            "To": "18-Dec-2024",
            "EmployeeId": "26",
            "ZUID": 797619148,
            "Employee.ID": 429525000009129000,
            "DateOfRequest": "09-Sep-2024",
            "Zoho_ID": 429525000013715000,
            "Leavetype_ID": 429525000000532160,
            "Employee_ID": 429525000009129000
        },
        {
            "Zoho.ID": 429525000013979000,
            "From": "18-Oct-2024",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Rica Harivonjy",
            "Leavetype": "Holiday Mada",
            "Days": {
                "18-Oct-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "18-Oct-2024",
            "EmployeeId": "22",
            "ZUID": 785524973,
            "Employee.ID": 429525000008263040,
            "DateOfRequest": "11-Oct-2024",
            "Zoho_ID": 429525000013979000,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000008263040
        },
        {
            "Zoho.ID": 429525000014271000,
            "From": "18-Nov-2024",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Ithiel Ramaroharinosy",
            "Leavetype": "Holiday Mada",
            "Days": {
                "18-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "18-Nov-2024",
            "EmployeeId": "21",
            "ZUID": 784439171,
            "Employee.ID": 429525000008278000,
            "DateOfRequest": "11-Nov-2024",
            "Zoho_ID": 429525000014271000,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000008278000
        },
        {
            "Zoho.ID": 429525000014298200,
            "From": "29-Jan-2025",
            "Leavetype.ID": 429525000000532160,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Yves Muyters",
            "Leavetype": "Verlof - onbetaald",
            "Days": {
                "29-Jan-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "29-Jan-2025",
            "EmployeeId": "12",
            "ZUID": 714687561,
            "Employee.ID": 429525000001514300,
            "DateOfRequest": "13-Nov-2024",
            "Zoho_ID": 429525000014298200,
            "Leavetype_ID": 429525000000532160,
            "Employee_ID": 429525000001514300
        },
        {
            "Zoho.ID": 429525000014298050,
            "From": "06-Dec-2024",
            "Leavetype.ID": 429525000000837000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "PAID",
            "Employee": "Jeroen Samyn",
            "Leavetype": "ADV-dagen",
            "Days": {
                "06-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "06-Dec-2024",
            "EmployeeId": "5",
            "ZUID": 666117247,
            "Employee.ID": 429525000000133000,
            "DateOfRequest": "12-Nov-2024",
            "Zoho_ID": 429525000014298050,
            "Leavetype_ID": 429525000000837000,
            "Employee_ID": 429525000000133000
        },
        {
            "Zoho.ID": 429525000014193000,
            "From": "11-Nov-2024",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Anjatiana Ramalala",
            "Leavetype": "Holiday Mada",
            "Days": {
                "11-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "11-Nov-2024",
            "EmployeeId": "33",
            "ZUID": 838491050,
            "Employee.ID": 429525000011962000,
            "DateOfRequest": "04-Nov-2024",
            "Zoho_ID": 429525000014193000,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000011962000
        },
        {
            "Zoho.ID": 429525000014734000,
            "From": "26-Dec-2024",
            "Leavetype.ID": 429525000006640000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Reason": "Begrafenis",
            "Type": "PAID",
            "Employee": "Simon Struyf",
            "Leavetype": "Klein verlet",
            "Days": {
                "26-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "26-Dec-2024",
            "EmployeeId": "14",
            "ZUID": 725755779,
            "Employee.ID": 429525000002724030,
            "DateOfRequest": "23-Dec-2024",
            "Zoho_ID": 429525000014734000,
            "Leavetype_ID": 429525000006640000,
            "Employee_ID": 429525000002724030
        },
        {
            "Zoho.ID": 429525000013544060,
            "From": "18-Oct-2024",
            "Leavetype.ID": 429525000000532160,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "PAID",
            "Employee": "Benjamin Donck",
            "Leavetype": "Public Holiday",
            "Days": {
                "18-Oct-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "18-Oct-2024",
            "EmployeeId": "19",
            "ZUID": 762557813,
            "Employee.ID": 429525000005886000,
            "DateOfRequest": "13-Aug-2024",
            "Zoho_ID": 429525000013544060,
            "Leavetype_ID": 429525000000532160,
            "Employee_ID": 429525000005886000
        },
        {
            "Zoho.ID": 429525000013990140,
            "From": "21-Oct-2024",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Andriamirado Nomenjanahary",
            "Leavetype": "Holiday Mada",
            "Days": {
                "21-Oct-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "22-Oct-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "22-Oct-2024",
            "EmployeeId": "29",
            "ZUID": 806777619,
            "Employee.ID": 429525000010013000,
            "DateOfRequest": "16-Oct-2024",
            "Zoho_ID": 429525000013990140,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000010013000
        },
        {
            "Zoho.ID": 429525000014192000,
            "From": "11-Nov-2024",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Andriamirado Nomenjanahary",
            "Leavetype": "Holiday Mada",
            "Days": {
                "11-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "11-Nov-2024",
            "EmployeeId": "29",
            "ZUID": 806777619,
            "Employee.ID": 429525000010013000,
            "DateOfRequest": "04-Nov-2024",
            "Zoho_ID": 429525000014192000,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000010013000
        },
        {
            "Zoho.ID": 429525000011741440,
            "From": "06-Nov-2024",
            "Leavetype.ID": 429525000000532160,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Yves Muyters",
            "Leavetype": "Verlof - onbetaald",
            "Days": {
                "06-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "06-Nov-2024",
            "EmployeeId": "12",
            "ZUID": 714687561,
            "Employee.ID": 429525000001514300,
            "DateOfRequest": "20-Nov-2023",
            "Zoho_ID": 429525000011741440,
            "Leavetype_ID": 429525000000532160,
            "Employee_ID": 429525000001514300
        },
        {
            "Zoho.ID": 429525000014694000,
            "From": "12-Apr-2025",
            "Leavetype.ID": 429525000000532160,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Reason": "Skivakantie",
            "Type": "UNPAID",
            "Employee": "Antoine Gerard",
            "Leavetype": "Verlof - onbetaald",
            "Days": {
                "12-Apr-2025": {
                    "LeaveCount": "0.0",
                    "Session": 1
                },
                "20-Apr-2025": {
                    "LeaveCount": "0.0",
                    "Session": 1
                },
                "15-Apr-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "17-Apr-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "16-Apr-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "19-Apr-2025": {
                    "LeaveCount": "0.0",
                    "Session": 1
                },
                "13-Apr-2025": {
                    "LeaveCount": "0.0",
                    "Session": 1
                },
                "14-Apr-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "18-Apr-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "20-Apr-2025",
            "EmployeeId": "1",
            "ZUID": 48329373,
            "Employee.ID": 429525000000123000,
            "DateOfRequest": "19-Dec-2024",
            "Zoho_ID": 429525000014694000,
            "Leavetype_ID": 429525000000532160,
            "Employee_ID": 429525000000123000
        },
        {
            "Zoho.ID": 429525000014454000,
            "From": "02-Dec-2024",
            "Leavetype.ID": 429525000000837000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "PAID",
            "Employee": "Dennis San A Jong",
            "Leavetype": "ADV-dagen",
            "Days": {
                "02-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "02-Dec-2024",
            "EmployeeId": "31",
            "ZUID": 825303249,
            "Employee.ID": 429525000011129000,
            "DateOfRequest": "27-Nov-2024",
            "Zoho_ID": 429525000014454000,
            "Leavetype_ID": 429525000000837000,
            "Employee_ID": 429525000011129000
        },
        {
            "Zoho.ID": 429525000013095040,
            "From": "04-Nov-2024",
            "Leavetype.ID": 429525000000532200,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "PAID",
            "Employee": "Simon Struyf",
            "Leavetype": "Holiday",
            "Days": {
                "22-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "18-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "12-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "16-Nov-2024": {
                    "LeaveCount": "0.0",
                    "Session": 1
                },
                "10-Nov-2024": {
                    "LeaveCount": "0.0",
                    "Session": 1
                },
                "08-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "17-Nov-2024": {
                    "LeaveCount": "0.0",
                    "Session": 1
                },
                "13-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "04-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "07-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "20-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "14-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "19-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "05-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "21-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "06-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "09-Nov-2024": {
                    "LeaveCount": "0.0",
                    "Session": 1
                },
                "11-Nov-2024": {
                    "LeaveCount": "0.0",
                    "Session": 1
                },
                "15-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "22-Nov-2024",
            "EmployeeId": "14",
            "ZUID": 725755779,
            "Employee.ID": 429525000002724030,
            "DateOfRequest": "04-Jun-2024",
            "Zoho_ID": 429525000013095040,
            "Leavetype_ID": 429525000000532200,
            "Employee_ID": 429525000002724030
        },
        {
            "Zoho.ID": 429525000014511000,
            "From": "18-Dec-2024",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Anjatiana Ramalala",
            "Leavetype": "Holiday Mada",
            "Days": {
                "18-Dec-2024": {
                    "LeaveCount": "0.5",
                    "EndTime": "17:30",
                    "StartTime": "13:15",
                    "Session": 2
                }
            },
            "To": "18-Dec-2024",
            "EmployeeId": "33",
            "ZUID": 838491050,
            "Employee.ID": 429525000011962000,
            "DateOfRequest": "02-Dec-2024",
            "Zoho_ID": 429525000014511000,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000011962000
        },
        {
            "Zoho.ID": 429525000014148030,
            "From": "04-Dec-2024",
            "Leavetype.ID": 429525000000532200,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "PAID",
            "Employee": "Jeroen Samyn",
            "Leavetype": "Holiday",
            "Days": {
                "04-Dec-2024": {
                    "LeaveCount": "0.5",
                    "EndTime": "17:30",
                    "StartTime": "13:15",
                    "Session": 2
                }
            },
            "To": "04-Dec-2024",
            "EmployeeId": "5",
            "ZUID": 666117247,
            "Employee.ID": 429525000000133000,
            "DateOfRequest": "06-Nov-2024",
            "Zoho_ID": 429525000014148030,
            "Leavetype_ID": 429525000000532200,
            "Employee_ID": 429525000000133000
        },
        {
            "Zoho.ID": 429525000014702000,
            "From": "19-Dec-2024",
            "Leavetype.ID": 429525000006640000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Reason": "Overlijden grootvader",
            "Type": "PAID",
            "Employee": "Simon Struyf",
            "Leavetype": "Klein verlet",
            "Days": {
                "19-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "19-Dec-2024",
            "EmployeeId": "14",
            "ZUID": 725755779,
            "Employee.ID": 429525000002724030,
            "DateOfRequest": "19-Dec-2024",
            "Zoho_ID": 429525000014702000,
            "Leavetype_ID": 429525000006640000,
            "Employee_ID": 429525000002724030
        },
        {
            "Zoho.ID": 429525000014298700,
            "From": "13-Feb-2025",
            "Leavetype.ID": 429525000000532160,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Yves Muyters",
            "Leavetype": "Verlof - onbetaald",
            "Days": {
                "13-Feb-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "14-Feb-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "14-Feb-2025",
            "EmployeeId": "12",
            "ZUID": 714687561,
            "Employee.ID": 429525000001514300,
            "DateOfRequest": "13-Nov-2024",
            "Zoho_ID": 429525000014298700,
            "Leavetype_ID": 429525000000532160,
            "Employee_ID": 429525000001514300
        },
        {
            "Zoho.ID": 429525000014573060,
            "From": "24-Dec-2024",
            "Leavetype.ID": 429525000000837000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "PAID",
            "Employee": "Benjamin Donck",
            "Leavetype": "ADV-dagen",
            "Days": {
                "24-Dec-2024": {
                    "LeaveCount": "0.5",
                    "EndTime": "17:30",
                    "StartTime": "13:15",
                    "Session": 2
                }
            },
            "To": "24-Dec-2024",
            "EmployeeId": "19",
            "ZUID": 762557813,
            "Employee.ID": 429525000005886000,
            "DateOfRequest": "10-Dec-2024",
            "Zoho_ID": 429525000014573060,
            "Leavetype_ID": 429525000000837000,
            "Employee_ID": 429525000005886000
        },
        {
            "Zoho.ID": 429525000013964000,
            "From": "04-Nov-2024",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Chrystèle Rakotomalala",
            "Leavetype": "Holiday Mada",
            "Days": {
                "04-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "07-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "05-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "08-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "06-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "08-Nov-2024",
            "EmployeeId": "24",
            "ZUID": 788509212,
            "Employee.ID": 429525000008507000,
            "DateOfRequest": "16-Oct-2024",
            "Zoho_ID": 429525000013964000,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000008507000
        },
        {
            "Zoho.ID": 429525000014298000,
            "From": "29-Nov-2024",
            "Leavetype.ID": 429525000000532200,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "PAID",
            "Employee": "Jeroen Samyn",
            "Leavetype": "Holiday",
            "Days": {
                "29-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "29-Nov-2024",
            "EmployeeId": "5",
            "ZUID": 666117247,
            "Employee.ID": 429525000000133000,
            "DateOfRequest": "12-Nov-2024",
            "Zoho_ID": 429525000014298000,
            "Leavetype_ID": 429525000000532200,
            "Employee_ID": 429525000000133000
        },
        {
            "Zoho.ID": 429525000014573000,
            "From": "26-Dec-2024",
            "Leavetype.ID": 429525000000837000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "PAID",
            "Employee": "Benjamin Donck",
            "Leavetype": "ADV-dagen",
            "Days": {
                "26-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "27-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "27-Dec-2024",
            "EmployeeId": "19",
            "ZUID": 762557813,
            "Employee.ID": 429525000005886000,
            "DateOfRequest": "10-Dec-2024",
            "Zoho_ID": 429525000014573000,
            "Leavetype_ID": 429525000000837000,
            "Employee_ID": 429525000005886000
        },
        {
            "Zoho.ID": 429525000014531000,
            "From": "26-Dec-2024",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Mendrika Ramiharimanitra",
            "Leavetype": "Holiday Mada",
            "Days": {
                "26-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "27-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "27-Dec-2024",
            "EmployeeId": "20",
            "ZUID": 762547585,
            "Employee.ID": 429525000006096000,
            "DateOfRequest": "03-Dec-2024",
            "Zoho_ID": 429525000014531000,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000006096000
        },
        {
            "Zoho.ID": 429525000013959100,
            "From": "04-Nov-2024",
            "Leavetype.ID": 429525000000532200,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "PAID",
            "Employee": "Ernst Harnie",
            "Leavetype": "Holiday",
            "Days": {
                "04-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "07-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "05-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "08-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "06-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "08-Nov-2024",
            "EmployeeId": "4",
            "ZUID": 666449138,
            "Employee.ID": 429525000000132030,
            "DateOfRequest": "16-Oct-2024",
            "Zoho_ID": 429525000013959100,
            "Leavetype_ID": 429525000000532200,
            "Employee_ID": 429525000000132030
        },
        {
            "Zoho.ID": 429525000013959100,
            "From": "25-Dec-2024",
            "Leavetype.ID": 429525000000532200,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "PAID",
            "Employee": "Ernst Harnie",
            "Leavetype": "Holiday",
            "Days": {
                "26-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "29-Dec-2024": {
                    "LeaveCount": "0.0",
                    "Session": 1
                },
                "01-Jan-2025": {
                    "LeaveCount": "0.0",
                    "Session": 1
                },
                "27-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "31-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "25-Dec-2024": {
                    "LeaveCount": "0.0",
                    "Session": 1
                },
                "30-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "02-Jan-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "28-Dec-2024": {
                    "LeaveCount": "0.0",
                    "Session": 1
                }
            },
            "To": "02-Jan-2025",
            "EmployeeId": "4",
            "ZUID": 666449138,
            "Employee.ID": 429525000000132030,
            "DateOfRequest": "16-Oct-2024",
            "Zoho_ID": 429525000013959100,
            "Leavetype_ID": 429525000000532200,
            "Employee_ID": 429525000000132030
        },
        {
            "Zoho.ID": 429525000014695000,
            "From": "06-Jan-2025",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Reason": "Holiday",
            "Type": "UNPAID",
            "Employee": "Nick Razafimanantsoa",
            "Leavetype": "Holiday Mada",
            "Days": {
                "09-Jan-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "07-Jan-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "10-Jan-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "06-Jan-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "08-Jan-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "10-Jan-2025",
            "EmployeeId": "HRM4",
            "ZUID": 873555777,
            "Employee.ID": 429525000014573060,
            "DateOfRequest": "19-Dec-2024",
            "Zoho_ID": 429525000014695000,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000014573060
        },
        {
            "Zoho.ID": 429525000014668000,
            "From": "24-Dec-2024",
            "Leavetype.ID": 429525000000532160,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Amina Fajjia",
            "Leavetype": "Verlof - onbetaald",
            "Days": {
                "24-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "24-Dec-2024",
            "EmployeeId": "HRM1",
            "ZUID": 856545530,
            "Employee.ID": 429525000013227000,
            "DateOfRequest": "17-Dec-2024",
            "Zoho_ID": 429525000014668000,
            "Leavetype_ID": 429525000000532160,
            "Employee_ID": 429525000013227000
        },
        {
            "Zoho.ID": 429525000014511040,
            "From": "19-Dec-2024",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Anjatiana Ramalala",
            "Leavetype": "Holiday Mada",
            "Days": {
                "19-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "19-Dec-2024",
            "EmployeeId": "33",
            "ZUID": 838491050,
            "Employee.ID": 429525000011962000,
            "DateOfRequest": "02-Dec-2024",
            "Zoho_ID": 429525000014511040,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000011962000
        },
        {
            "Zoho.ID": 429525000014148030,
            "From": "27-Nov-2024",
            "Leavetype.ID": 429525000000532200,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "PAID",
            "Employee": "Jeroen Samyn",
            "Leavetype": "Holiday",
            "Days": {
                "27-Nov-2024": {
                    "LeaveCount": "0.5",
                    "EndTime": "17:30",
                    "StartTime": "13:15",
                    "Session": 2
                }
            },
            "To": "27-Nov-2024",
            "EmployeeId": "5",
            "ZUID": 666117247,
            "Employee.ID": 429525000000133000,
            "DateOfRequest": "06-Nov-2024",
            "Zoho_ID": 429525000014148030,
            "Leavetype_ID": 429525000000532200,
            "Employee_ID": 429525000000133000
        },
        {
            "Zoho.ID": 429525000014298000,
            "From": "22-Nov-2024",
            "Leavetype.ID": 429525000000532200,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "PAID",
            "Employee": "Jeroen Samyn",
            "Leavetype": "Holiday",
            "Days": {
                "22-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "22-Nov-2024",
            "EmployeeId": "5",
            "ZUID": 666117247,
            "Employee.ID": 429525000000133000,
            "DateOfRequest": "12-Nov-2024",
            "Zoho_ID": 429525000014298000,
            "Leavetype_ID": 429525000000532200,
            "Employee_ID": 429525000000133000
        },
        {
            "Zoho.ID": 429525000014299100,
            "From": "13-Mar-2025",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Nambinina Ratovolalao",
            "Leavetype": "Holiday Mada",
            "Days": {
                "14-Mar-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "13-Mar-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "14-Mar-2025",
            "EmployeeId": "28",
            "ZUID": 806776542,
            "Employee.ID": 429525000010013000,
            "DateOfRequest": "13-Nov-2024",
            "Zoho_ID": 429525000014299100,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000010013000
        },
        {
            "Zoho.ID": 429525000014573000,
            "From": "22-Nov-2024",
            "Leavetype.ID": 429525000000532200,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "PAID",
            "Employee": "Anjatiana Ramalala",
            "Leavetype": "Sickness",
            "Days": {
                "22-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "22-Nov-2024",
            "EmployeeId": "33",
            "ZUID": 838491050,
            "Employee.ID": 429525000011962000,
            "DateOfRequest": "06-Dec-2024",
            "Zoho_ID": 429525000014573000,
            "Leavetype_ID": 429525000000532200,
            "Employee_ID": 429525000011962000
        },
        {
            "Zoho.ID": 429525000014720000,
            "From": "26-Dec-2024",
            "Leavetype.ID": 429525000000837000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "PAID",
            "Employee": "Medina Dadurgova",
            "Leavetype": "ADV-dagen",
            "Days": {
                "26-Dec-2024": {
                    "LeaveCount": "0.5",
                    "EndTime": "17:30",
                    "StartTime": "13:15",
                    "Session": 2
                },
                "27-Dec-2024": {
                    "LeaveCount": "0.5",
                    "EndTime": "17:30",
                    "StartTime": "13:15",
                    "Session": 2
                }
            },
            "To": "27-Dec-2024",
            "EmployeeId": "30",
            "ZUID": 810863591,
            "Employee.ID": 429525000010438000,
            "DateOfRequest": "24-Dec-2024",
            "Zoho_ID": 429525000014720000,
            "Leavetype_ID": 429525000000837000,
            "Employee_ID": 429525000010438000
        },
        {
            "Zoho.ID": 429525000014148030,
            "From": "13-Nov-2024",
            "Leavetype.ID": 429525000000532200,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "PAID",
            "Employee": "Jeroen Samyn",
            "Leavetype": "Holiday",
            "Days": {
                "13-Nov-2024": {
                    "LeaveCount": "0.5",
                    "EndTime": "17:30",
                    "StartTime": "13:15",
                    "Session": 2
                }
            },
            "To": "13-Nov-2024",
            "EmployeeId": "5",
            "ZUID": 666117247,
            "Employee.ID": 429525000000133000,
            "DateOfRequest": "06-Nov-2024",
            "Zoho_ID": 429525000014148030,
            "Leavetype_ID": 429525000000532200,
            "Employee_ID": 429525000000133000
        },
        {
            "Zoho.ID": 429525000014378000,
            "From": "29-Nov-2024",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Ithiel Ramaroharinosy",
            "Leavetype": "Holiday Mada",
            "Days": {
                "29-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "29-Nov-2024",
            "EmployeeId": "21",
            "ZUID": 784439171,
            "Employee.ID": 429525000008278000,
            "DateOfRequest": "22-Nov-2024",
            "Zoho_ID": 429525000014378000,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000008278000
        },
        {
            "Zoho.ID": 429525000014298240,
            "From": "09-Apr-2025",
            "Leavetype.ID": 429525000000532160,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Yves Muyters",
            "Leavetype": "Verlof - onbetaald",
            "Days": {
                "09-Apr-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "09-Apr-2025",
            "EmployeeId": "12",
            "ZUID": 714687561,
            "Employee.ID": 429525000001514300,
            "DateOfRequest": "13-Nov-2024",
            "Zoho_ID": 429525000014298240,
            "Leavetype_ID": 429525000000532160,
            "Employee_ID": 429525000001514300
        },
        {
            "Zoho.ID": 429525000013959100,
            "From": "23-Dec-2024",
            "Leavetype.ID": 429525000000837000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "PAID",
            "Employee": "Ernst Harnie",
            "Leavetype": "ADV-dagen",
            "Days": {
                "24-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "23-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "24-Dec-2024",
            "EmployeeId": "4",
            "ZUID": 666449138,
            "Employee.ID": 429525000000132030,
            "DateOfRequest": "16-Oct-2024",
            "Zoho_ID": 429525000013959100,
            "Leavetype_ID": 429525000000837000,
            "Employee_ID": 429525000000132030
        },
        {
            "Zoho.ID": 429525000014298100,
            "From": "15-Jan-2025",
            "Leavetype.ID": 429525000000532160,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Yves Muyters",
            "Leavetype": "Verlof - onbetaald",
            "Days": {
                "15-Jan-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "15-Jan-2025",
            "EmployeeId": "12",
            "ZUID": 714687561,
            "Employee.ID": 429525000001514300,
            "DateOfRequest": "13-Nov-2024",
            "Zoho_ID": 429525000014298100,
            "Leavetype_ID": 429525000000532160,
            "Employee_ID": 429525000001514300
        },
        {
            "Zoho.ID": 429525000011741440,
            "From": "23-Oct-2024",
            "Leavetype.ID": 429525000000532160,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Yves Muyters",
            "Leavetype": "Verlof - onbetaald",
            "Days": {
                "23-Oct-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "23-Oct-2024",
            "EmployeeId": "12",
            "ZUID": 714687561,
            "Employee.ID": 429525000001514300,
            "DateOfRequest": "20-Nov-2023",
            "Zoho_ID": 429525000011741440,
            "Leavetype_ID": 429525000000532160,
            "Employee_ID": 429525000001514300
        },
        {
            "Zoho.ID": 429525000013654100,
            "From": "29-Nov-2024",
            "Leavetype.ID": 429525000000837000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "PAID",
            "Employee": "Michel Van Steenbergen",
            "Leavetype": "ADV-dagen",
            "Days": {
                "29-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "29-Nov-2024",
            "EmployeeId": "8",
            "ZUID": 702303420,
            "Employee.ID": 429525000000812000,
            "DateOfRequest": "02-Sep-2024",
            "Zoho_ID": 429525000013654100,
            "Leavetype_ID": 429525000000837000,
            "Employee_ID": 429525000000812000
        },
        {
            "Zoho.ID": 429525000014298600,
            "From": "10-Feb-2025",
            "Leavetype.ID": 429525000000532160,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Yves Muyters",
            "Leavetype": "Verlof - onbetaald",
            "Days": {
                "11-Feb-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "10-Feb-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "11-Feb-2025",
            "EmployeeId": "12",
            "ZUID": 714687561,
            "Employee.ID": 429525000001514300,
            "DateOfRequest": "13-Nov-2024",
            "Zoho_ID": 429525000014298600,
            "Leavetype_ID": 429525000000532160,
            "Employee_ID": 429525000001514300
        },
        {
            "Zoho.ID": 429525000013544060,
            "From": "17-Oct-2024",
            "Leavetype.ID": 429525000000837000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "PAID",
            "Employee": "Benjamin Donck",
            "Leavetype": "ADV-dagen",
            "Days": {
                "17-Oct-2024": {
                    "LeaveCount": "0.5",
                    "EndTime": "17:30",
                    "StartTime": "13:15",
                    "Session": 2
                }
            },
            "To": "17-Oct-2024",
            "EmployeeId": "19",
            "ZUID": 762557813,
            "Employee.ID": 429525000005886000,
            "DateOfRequest": "13-Aug-2024",
            "Zoho_ID": 429525000013544060,
            "Leavetype_ID": 429525000000837000,
            "Employee_ID": 429525000005886000
        },
        {
            "Zoho.ID": 429525000014454000,
            "From": "06-Dec-2024",
            "Leavetype.ID": 429525000000837000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "PAID",
            "Employee": "Dennis San A Jong",
            "Leavetype": "ADV-dagen",
            "Days": {
                "06-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "06-Dec-2024",
            "EmployeeId": "31",
            "ZUID": 825303249,
            "Employee.ID": 429525000011129000,
            "DateOfRequest": "27-Nov-2024",
            "Zoho_ID": 429525000014454000,
            "Leavetype_ID": 429525000000837000,
            "Employee_ID": 429525000011129000
        },
        {
            "Zoho.ID": 429525000014061000,
            "From": "26-Dec-2024",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Anna Dimby",
            "Leavetype": "Holiday Mada",
            "Days": {
                "26-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "26-Dec-2024",
            "EmployeeId": "2",
            "ZUID": 630148561,
            "Employee.ID": 429525000000130000,
            "DateOfRequest": "23-Oct-2024",
            "Zoho_ID": 429525000014061000,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000000130000
        },
        {
            "Zoho.ID": 429525000014193000,
            "From": "15-Nov-2024",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Anjatiana Ramalala",
            "Leavetype": "Holiday Mada",
            "Days": {
                "15-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "15-Nov-2024",
            "EmployeeId": "33",
            "ZUID": 838491050,
            "Employee.ID": 429525000011962000,
            "DateOfRequest": "04-Nov-2024",
            "Zoho_ID": 429525000014193000,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000011962000
        },
        {
            "Zoho.ID": 429525000014704000,
            "From": "18-Dec-2024",
            "Leavetype.ID": 429525000000532200,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "PAID",
            "Employee": "Benjamin Donck",
            "Leavetype": "Sickness",
            "Days": {
                "18-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "19-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "19-Dec-2024",
            "EmployeeId": "19",
            "ZUID": 762557813,
            "Employee.ID": 429525000005886000,
            "DateOfRequest": "19-Dec-2024",
            "Zoho_ID": 429525000014704000,
            "Leavetype_ID": 429525000000532200,
            "Employee_ID": 429525000005886000
        },
        {
            "Zoho.ID": 429525000014726000,
            "From": "19-Dec-2024",
            "Leavetype.ID": 429525000000532160,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Flor Holvoet",
            "Leavetype": "Verlof - onbetaald",
            "Days": {
                "19-Dec-2024": {
                    "LeaveCount": "0.5",
                    "EndTime": "13:15",
                    "StartTime": "09:00",
                    "Session": 1
                }
            },
            "To": "19-Dec-2024",
            "EmployeeId": "15",
            "ZUID": 677479444,
            "Employee.ID": 429525000002773000,
            "DateOfRequest": "23-Dec-2024",
            "Zoho_ID": 429525000014726000,
            "Leavetype_ID": 429525000000532160,
            "Employee_ID": 429525000002773000
        },
        {
            "Zoho.ID": 429525000014457000,
            "From": "10-Dec-2024",
            "Leavetype.ID": 429525000000837000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "PAID",
            "Employee": "Lesley Jacobs",
            "Leavetype": "ADV-dagen",
            "Days": {
                "10-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "14:30",
                    "StartTime": "09:00"
                }
            },
            "To": "10-Dec-2024",
            "EmployeeId": "25",
            "ZUID": 795262248,
            "Employee.ID": 429525000008981000,
            "DateOfRequest": "29-Nov-2024",
            "Zoho_ID": 429525000014457000,
            "Leavetype_ID": 429525000000837000,
            "Employee_ID": 429525000008981000
        },
        {
            "Zoho.ID": 429525000014539000,
            "From": "17-Dec-2024",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Chrystèle Rakotomalala",
            "Leavetype": "Holiday Mada",
            "Days": {
                "17-Dec-2024": {
                    "LeaveCount": "0.5",
                    "EndTime": "13:15",
                    "StartTime": "09:00",
                    "Session": 1
                }
            },
            "To": "17-Dec-2024",
            "EmployeeId": "24",
            "ZUID": 788509212,
            "Employee.ID": 429525000008507000,
            "DateOfRequest": "12-Dec-2024",
            "Zoho_ID": 429525000014539000,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000008507000
        },
        {
            "Zoho.ID": 429525000014668000,
            "From": "26-Dec-2024",
            "Leavetype.ID": 429525000000532160,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Amina Fajjia",
            "Leavetype": "Verlof - onbetaald",
            "Days": {
                "26-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "26-Dec-2024",
            "EmployeeId": "HRM1",
            "ZUID": 856545530,
            "Employee.ID": 429525000013227000,
            "DateOfRequest": "17-Dec-2024",
            "Zoho_ID": 429525000014668000,
            "Leavetype_ID": 429525000000532160,
            "Employee_ID": 429525000013227000
        },
        {
            "Zoho.ID": 429525000014800000,
            "From": "30-Dec-2024",
            "Leavetype.ID": 429525000000532160,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Damiaan Peeters",
            "Leavetype": "Verlof - onbetaald",
            "Days": {
                "31-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "30-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "31-Dec-2024",
            "EmployeeId": "26",
            "ZUID": 797619148,
            "Employee.ID": 429525000009129000,
            "DateOfRequest": "30-Dec-2024",
            "Zoho_ID": 429525000014800000,
            "Leavetype_ID": 429525000000532160,
            "Employee_ID": 429525000009129000
        },
        {
            "Zoho.ID": 429525000014298100,
            "From": "06-Jan-2025",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Andriamirado Nomenjanahary",
            "Leavetype": "Holiday Mada",
            "Days": {
                "07-Jan-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "06-Jan-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "08-Jan-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "08-Jan-2025",
            "EmployeeId": "29",
            "ZUID": 806777619,
            "Employee.ID": 429525000010013000,
            "DateOfRequest": "13-Nov-2024",
            "Zoho_ID": 429525000014298100,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000010013000
        },
        {
            "Zoho.ID": 429525000014709000,
            "From": "27-Dec-2024",
            "Leavetype.ID": 429525000000532160,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Amina Fajjia",
            "Leavetype": "Verlof - onbetaald",
            "Days": {
                "27-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "27-Dec-2024",
            "EmployeeId": "HRM1",
            "ZUID": 856545530,
            "Employee.ID": 429525000013227000,
            "DateOfRequest": "22-Dec-2024",
            "Zoho_ID": 429525000014709000,
            "Leavetype_ID": 429525000000532160,
            "Employee_ID": 429525000013227000
        },
        {
            "Zoho.ID": 429525000014298100,
            "From": "30-Jan-2025",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Andriamirado Nomenjanahary",
            "Leavetype": "Holiday Mada",
            "Days": {
                "30-Jan-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "31-Jan-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "31-Jan-2025",
            "EmployeeId": "29",
            "ZUID": 806777619,
            "Employee.ID": 429525000010013000,
            "DateOfRequest": "13-Nov-2024",
            "Zoho_ID": 429525000014298100,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000010013000
        },
        {
            "Zoho.ID": 429525000014800060,
            "From": "03-Jan-2025",
            "Leavetype.ID": 429525000000532160,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Damiaan Peeters",
            "Leavetype": "Verlof - onbetaald",
            "Days": {
                "03-Jan-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "03-Jan-2025",
            "EmployeeId": "26",
            "ZUID": 797619148,
            "Employee.ID": 429525000009129000,
            "DateOfRequest": "30-Dec-2024",
            "Zoho_ID": 429525000014800060,
            "Leavetype_ID": 429525000000532160,
            "Employee_ID": 429525000009129000
        },
        {
            "Zoho.ID": 429525000014511040,
            "From": "20-Dec-2024",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Anjatiana Ramalala",
            "Leavetype": "Holiday Mada",
            "Days": {
                "20-Dec-2024": {
                    "LeaveCount": "0.5",
                    "EndTime": "13:15",
                    "StartTime": "09:00",
                    "Session": 1
                }
            },
            "To": "20-Dec-2024",
            "EmployeeId": "33",
            "ZUID": 838491050,
            "Employee.ID": 429525000011962000,
            "DateOfRequest": "02-Dec-2024",
            "Zoho_ID": 429525000014511040,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000011962000
        },
        {
            "Zoho.ID": 429525000014298940,
            "From": "22-Nov-2024",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Mendrika Ramiharimanitra",
            "Leavetype": "Holiday Mada",
            "Days": {
                "22-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "22-Nov-2024",
            "EmployeeId": "20",
            "ZUID": 762547585,
            "Employee.ID": 429525000006096000,
            "DateOfRequest": "14-Nov-2024",
            "Zoho_ID": 429525000014298940,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000006096000
        },
        {
            "Zoho.ID": 429525000014454000,
            "From": "09-Dec-2024",
            "Leavetype.ID": 429525000000532160,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Dennis San A Jong",
            "Leavetype": "Verlof - onbetaald",
            "Days": {
                "09-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "09-Dec-2024",
            "EmployeeId": "31",
            "ZUID": 825303249,
            "Employee.ID": 429525000011129000,
            "DateOfRequest": "29-Nov-2024",
            "Zoho_ID": 429525000014454000,
            "Leavetype_ID": 429525000000532160,
            "Employee_ID": 429525000011129000
        },
        {
            "Zoho.ID": 429525000013727040,
            "From": "14-Feb-2025",
            "Leavetype.ID": 429525000000532160,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Reason": "Anniversary-ish",
            "Type": "UNPAID",
            "Employee": "Robin Van Gijseghem ",
            "Leavetype": "Verlof - onbetaald",
            "Days": {
                "15-Feb-2025": {
                    "LeaveCount": "0.0",
                    "Session": 1
                },
                "14-Feb-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "17-Feb-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "16-Feb-2025": {
                    "LeaveCount": "0.0",
                    "Session": 1
                }
            },
            "To": "17-Feb-2025",
            "EmployeeId": "17",
            "ZUID": 738663195,
            "Employee.ID": 429525000003851000,
            "DateOfRequest": "11-Sep-2024",
            "Zoho_ID": 429525000013727040,
            "Leavetype_ID": 429525000000532160,
            "Employee_ID": 429525000003851000
        },
        {
            "Zoho.ID": 429525000014042100,
            "From": "23-Dec-2024",
            "Leavetype.ID": 429525000000532200,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "PAID",
            "Employee": "Lesley Jacobs",
            "Leavetype": "Holiday",
            "Days": {
                "24-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "14:30",
                    "StartTime": "09:00"
                },
                "26-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "14:30",
                    "StartTime": "09:00"
                },
                "27-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "14:30",
                    "StartTime": "09:00"
                },
                "25-Dec-2024": {
                    "LeaveCount": "0.0",
                    "Session": 1
                },
                "23-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "14:30",
                    "StartTime": "09:00"
                }
            },
            "To": "27-Dec-2024",
            "EmployeeId": "25",
            "ZUID": 795262248,
            "Employee.ID": 429525000008981000,
            "DateOfRequest": "25-Oct-2024",
            "Zoho_ID": 429525000014042100,
            "Leavetype_ID": 429525000000532200,
            "Employee_ID": 429525000008981000
        },
        {
            "Zoho.ID": 429525000014192000,
            "From": "08-Nov-2024",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Mendrika Ramiharimanitra",
            "Leavetype": "Holiday Mada",
            "Days": {
                "08-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "08-Nov-2024",
            "EmployeeId": "20",
            "ZUID": 762547585,
            "Employee.ID": 429525000006096000,
            "DateOfRequest": "04-Nov-2024",
            "Zoho_ID": 429525000014192000,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000006096000
        },
        {
            "Zoho.ID": 429525000014074000,
            "From": "07-Nov-2024",
            "Leavetype.ID": 429525000000532200,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Reason": "Gastroscopie",
            "Type": "PAID",
            "Employee": "Benjamin Donck",
            "Leavetype": "Sickness",
            "Days": {
                "07-Nov-2024": {
                    "LeaveCount": "0.5",
                    "EndTime": "17:30",
                    "StartTime": "13:15",
                    "Session": 2
                }
            },
            "To": "07-Nov-2024",
            "EmployeeId": "19",
            "ZUID": 762557813,
            "Employee.ID": 429525000005886000,
            "DateOfRequest": "24-Oct-2024",
            "Zoho_ID": 429525000014074000,
            "Leavetype_ID": 429525000000532200,
            "Employee_ID": 429525000005886000
        },
        {
            "Zoho.ID": 429525000014830000,
            "From": "09-Jan-2025",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Anjatiana Ramalala",
            "Leavetype": "Holiday Mada",
            "Days": {
                "09-Jan-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "09-Jan-2025",
            "EmployeeId": "33",
            "ZUID": 838491050,
            "Employee.ID": 429525000011962000,
            "DateOfRequest": "02-Jan-2025",
            "Zoho_ID": 429525000014830000,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000011962000
        },
        {
            "Zoho.ID": 429525000014298200,
            "From": "26-Feb-2025",
            "Leavetype.ID": 429525000000532160,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Yves Muyters",
            "Leavetype": "Verlof - onbetaald",
            "Days": {
                "26-Feb-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "26-Feb-2025",
            "EmployeeId": "12",
            "ZUID": 714687561,
            "Employee.ID": 429525000001514300,
            "DateOfRequest": "13-Nov-2024",
            "Zoho_ID": 429525000014298200,
            "Leavetype_ID": 429525000000532160,
            "Employee_ID": 429525000001514300
        },
        {
            "Zoho.ID": 429525000013962050,
            "From": "16-Dec-2024",
            "Leavetype.ID": 429525000000532160,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Flor Holvoet",
            "Leavetype": "Verlof - onbetaald",
            "Days": {
                "16-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "18-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "17-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "18-Dec-2024",
            "EmployeeId": "15",
            "ZUID": 677479444,
            "Employee.ID": 429525000002773000,
            "DateOfRequest": "10-Oct-2024",
            "Zoho_ID": 429525000013962050,
            "Leavetype_ID": 429525000000532160,
            "Employee_ID": 429525000002773000
        },
        {
            "Zoho.ID": 429525000013979100,
            "From": "26-Dec-2024",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Rica Harivonjy",
            "Leavetype": "Holiday Mada",
            "Days": {
                "26-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "29-Dec-2024": {
                    "LeaveCount": "0.0",
                    "Session": 1
                },
                "01-Jan-2025": {
                    "LeaveCount": "0.0",
                    "Session": 1
                },
                "27-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "03-Jan-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "31-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "30-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "02-Jan-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "28-Dec-2024": {
                    "LeaveCount": "0.0",
                    "Session": 1
                }
            },
            "To": "03-Jan-2025",
            "EmployeeId": "22",
            "ZUID": 785524973,
            "Employee.ID": 429525000008263040,
            "DateOfRequest": "11-Oct-2024",
            "Zoho_ID": 429525000013979100,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000008263040
        },
        {
            "Zoho.ID": 429525000014120000,
            "From": "25-Oct-2024",
            "Leavetype.ID": 429525000000532200,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "PAID",
            "Employee": "Dennis San A Jong",
            "Leavetype": "Sickness",
            "Days": {
                "27-Oct-2024": {
                    "LeaveCount": "0.0",
                    "Session": 1
                },
                "25-Oct-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "28-Oct-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "26-Oct-2024": {
                    "LeaveCount": "0.0",
                    "Session": 1
                }
            },
            "To": "28-Oct-2024",
            "EmployeeId": "31",
            "ZUID": 825303249,
            "Employee.ID": 429525000011129000,
            "DateOfRequest": "28-Oct-2024",
            "Zoho_ID": 429525000014120000,
            "Leavetype_ID": 429525000000532200,
            "Employee_ID": 429525000011129000
        },
        {
            "Zoho.ID": 429525000013989000,
            "From": "31-Oct-2024",
            "Leavetype.ID": 429525000000532160,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "PAID",
            "Employee": "Lesley Jacobs",
            "Leavetype": "Public Holiday",
            "Days": {
                "31-Oct-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "14:30",
                    "StartTime": "09:00"
                }
            },
            "To": "31-Oct-2024",
            "EmployeeId": "25",
            "ZUID": 795262248,
            "Employee.ID": 429525000008981000,
            "DateOfRequest": "15-Oct-2024",
            "Zoho_ID": 429525000013989000,
            "Leavetype_ID": 429525000000532160,
            "Employee_ID": 429525000008981000
        },
        {
            "Zoho.ID": 429525000014298240,
            "From": "26-Mar-2025",
            "Leavetype.ID": 429525000000532160,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Yves Muyters",
            "Leavetype": "Verlof - onbetaald",
            "Days": {
                "26-Mar-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "26-Mar-2025",
            "EmployeeId": "12",
            "ZUID": 714687561,
            "Employee.ID": 429525000001514300,
            "DateOfRequest": "13-Nov-2024",
            "Zoho_ID": 429525000014298240,
            "Leavetype_ID": 429525000000532160,
            "Employee_ID": 429525000001514300
        },
        {
            "Zoho.ID": 429525000013959040,
            "From": "18-Oct-2024",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Chrystèle Rakotomalala",
            "Leavetype": "Holiday Mada",
            "Days": {
                "18-Oct-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "18-Oct-2024",
            "EmployeeId": "24",
            "ZUID": 788509212,
            "Employee.ID": 429525000008507000,
            "DateOfRequest": "10-Oct-2024",
            "Zoho_ID": 429525000013959040,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000008507000
        },
        {
            "Zoho.ID": 429525000014511040,
            "From": "27-Dec-2024",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Anna Dimby",
            "Leavetype": "Holiday Mada",
            "Days": {
                "29-Dec-2024": {
                    "LeaveCount": "0.0",
                    "Session": 1
                },
                "01-Jan-2025": {
                    "LeaveCount": "0.0",
                    "Session": 1
                },
                "27-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "03-Jan-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "31-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "07-Jan-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "05-Jan-2025": {
                    "LeaveCount": "0.0",
                    "Session": 1
                },
                "30-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "02-Jan-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "28-Dec-2024": {
                    "LeaveCount": "0.0",
                    "Session": 1
                },
                "04-Jan-2025": {
                    "LeaveCount": "0.0",
                    "Session": 1
                },
                "06-Jan-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "07-Jan-2025",
            "EmployeeId": "2",
            "ZUID": 630148561,
            "Employee.ID": 429525000000130000,
            "DateOfRequest": "02-Dec-2024",
            "Zoho_ID": 429525000014511040,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000000130000
        },
        {
            "Zoho.ID": 429525000014298050,
            "From": "19-Dec-2024",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Andriamirado Nomenjanahary",
            "Leavetype": "Holiday Mada",
            "Days": {
                "24-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "20-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "22-Dec-2024": {
                    "LeaveCount": "0.0",
                    "Session": 1
                },
                "23-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "19-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "21-Dec-2024": {
                    "LeaveCount": "0.0",
                    "Session": 1
                }
            },
            "To": "24-Dec-2024",
            "EmployeeId": "29",
            "ZUID": 806777619,
            "Employee.ID": 429525000010013000,
            "DateOfRequest": "13-Nov-2024",
            "Zoho_ID": 429525000014298050,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000010013000
        },
        {
            "Zoho.ID": 429525000014532030,
            "From": "09-Dec-2024",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Chrystèle Rakotomalala",
            "Leavetype": "Holiday Mada",
            "Days": {
                "10-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "09-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "10-Dec-2024",
            "EmployeeId": "24",
            "ZUID": 788509212,
            "Employee.ID": 429525000008507000,
            "DateOfRequest": "03-Dec-2024",
            "Zoho_ID": 429525000014532030,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000008507000
        },
        {
            "Zoho.ID": 429525000014299100,
            "From": "02-Jan-2025",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Nambinina Ratovolalao",
            "Leavetype": "Holiday Mada",
            "Days": {
                "03-Jan-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "02-Jan-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "03-Jan-2025",
            "EmployeeId": "28",
            "ZUID": 806776542,
            "Employee.ID": 429525000010013000,
            "DateOfRequest": "13-Nov-2024",
            "Zoho_ID": 429525000014299100,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000010013000
        },
        {
            "Zoho.ID": 429525000014427100,
            "From": "10-Mar-2025",
            "Leavetype.ID": 429525000000532160,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Reason": "Guatemala",
            "Type": "UNPAID",
            "Employee": "Flor Holvoet",
            "Leavetype": "Verlof - onbetaald",
            "Days": {
                "11-Mar-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "17-Mar-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "14-Mar-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "16-Mar-2025": {
                    "LeaveCount": "0.0",
                    "Session": 1
                },
                "20-Mar-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "18-Mar-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "12-Mar-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "15-Mar-2025": {
                    "LeaveCount": "0.0",
                    "Session": 1
                },
                "13-Mar-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "21-Mar-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "10-Mar-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "19-Mar-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "21-Mar-2025",
            "EmployeeId": "15",
            "ZUID": 677479444,
            "Employee.ID": 429525000002773000,
            "DateOfRequest": "25-Nov-2024",
            "Zoho_ID": 429525000014427100,
            "Leavetype_ID": 429525000000532160,
            "Employee_ID": 429525000002773000
        },
        {
            "Zoho.ID": 429525000014595000,
            "From": "03-Dec-2024",
            "Leavetype.ID": 429525000000532200,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Reason": "Sickness",
            "Type": "PAID",
            "Employee": "Toky Solofonirina‎",
            "Leavetype": "Sickness",
            "Days": {
                "03-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "03-Dec-2024",
            "EmployeeId": "HRM2",
            "ZUID": 868567453,
            "Employee.ID": 429525000013977000,
            "DateOfRequest": "09-Dec-2024",
            "Zoho_ID": 429525000014595000,
            "Leavetype_ID": 429525000000532200,
            "Employee_ID": 429525000013977000
        },
        {
            "Zoho.ID": 429525000014724030,
            "From": "31-Dec-2024",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Anjatiana Ramalala",
            "Leavetype": "Holiday Mada",
            "Days": {
                "31-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "31-Dec-2024",
            "EmployeeId": "33",
            "ZUID": 838491050,
            "Employee.ID": 429525000011962000,
            "DateOfRequest": "23-Dec-2024",
            "Zoho_ID": 429525000014724030,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000011962000
        },
        {
            "Zoho.ID": 429525000014833000,
            "From": "12-Apr-2025",
            "Leavetype.ID": 429525000000532200,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Reason": "Ski vakantie",
            "Type": "PAID",
            "Employee": "Benjamin Donck",
            "Leavetype": "Holiday",
            "Days": {
                "12-Apr-2025": {
                    "LeaveCount": "0.0",
                    "Session": 1
                },
                "15-Apr-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "17-Apr-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "16-Apr-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "19-Apr-2025": {
                    "LeaveCount": "0.0",
                    "Session": 1
                },
                "13-Apr-2025": {
                    "LeaveCount": "0.0",
                    "Session": 1
                },
                "14-Apr-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "18-Apr-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "19-Apr-2025",
            "EmployeeId": "19",
            "ZUID": 762557813,
            "Employee.ID": 429525000005886000,
            "DateOfRequest": "02-Jan-2025",
            "Zoho_ID": 429525000014833000,
            "Leavetype_ID": 429525000000532200,
            "Employee_ID": 429525000005886000
        },
        {
            "Zoho.ID": 429525000014298050,
            "From": "20-Dec-2024",
            "Leavetype.ID": 429525000000532100,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "PAID",
            "Employee": "Jeroen Samyn",
            "Leavetype": "Anciëniteitsverlof",
            "Days": {
                "20-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "20-Dec-2024",
            "EmployeeId": "5",
            "ZUID": 666117247,
            "Employee.ID": 429525000000133000,
            "DateOfRequest": "12-Nov-2024",
            "Zoho_ID": 429525000014298050,
            "Leavetype_ID": 429525000000532100,
            "Employee_ID": 429525000000133000
        },
        {
            "Zoho.ID": 429525000014377000,
            "From": "20-Nov-2024",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Reason": "Sickness",
            "Type": "UNPAID",
            "Employee": "Toky Solofonirina‎",
            "Leavetype": "Holiday Mada",
            "Days": {
                "20-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "20-Nov-2024",
            "EmployeeId": "HRM2",
            "ZUID": 868567453,
            "Employee.ID": 429525000013977000,
            "DateOfRequest": "22-Nov-2024",
            "Zoho_ID": 429525000014377000,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000013977000
        },
        {
            "Zoho.ID": 429525000013959040,
            "From": "03-Mar-2025",
            "Leavetype.ID": 429525000000532160,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Reason": "schoolvakantie (ski)",
            "Type": "UNPAID",
            "Employee": "Damiaan Peeters",
            "Leavetype": "Verlof - onbetaald",
            "Days": {
                "06-Mar-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "03-Mar-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "05-Mar-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "07-Mar-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "04-Mar-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "07-Mar-2025",
            "EmployeeId": "26",
            "ZUID": 797619148,
            "Employee.ID": 429525000009129000,
            "DateOfRequest": "15-Oct-2024",
            "Zoho_ID": 429525000013959040,
            "Leavetype_ID": 429525000000532160,
            "Employee_ID": 429525000009129000
        },
        {
            "Zoho.ID": 429525000013979000,
            "From": "06-Nov-2024",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Rica Harivonjy",
            "Leavetype": "Holiday Mada",
            "Days": {
                "07-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "12-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "14-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "10-Nov-2024": {
                    "LeaveCount": "0.0",
                    "Session": 1
                },
                "08-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "06-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "09-Nov-2024": {
                    "LeaveCount": "0.0",
                    "Session": 1
                },
                "11-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "13-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "15-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "15-Nov-2024",
            "EmployeeId": "22",
            "ZUID": 785524973,
            "Employee.ID": 429525000008263040,
            "DateOfRequest": "11-Oct-2024",
            "Zoho_ID": 429525000013979000,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000008263040
        },
        {
            "Zoho.ID": 429525000014573300,
            "From": "30-Dec-2024",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Ithiel Ramaroharinosy",
            "Leavetype": "Holiday Mada",
            "Days": {
                "31-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "30-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "31-Dec-2024",
            "EmployeeId": "21",
            "ZUID": 784439171,
            "Employee.ID": 429525000008278000,
            "DateOfRequest": "13-Dec-2024",
            "Zoho_ID": 429525000014573300,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000008278000
        },
        {
            "Zoho.ID": 429525000013937000,
            "From": "18-Oct-2024",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Anjatiana Ramalala",
            "Leavetype": "Holiday Mada",
            "Days": {
                "18-Oct-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "18-Oct-2024",
            "EmployeeId": "33",
            "ZUID": 838491050,
            "Employee.ID": 429525000011962000,
            "DateOfRequest": "09-Oct-2024",
            "Zoho_ID": 429525000013937000,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000011962000
        },
        {
            "Zoho.ID": 429525000011741500,
            "From": "04-Dec-2024",
            "Leavetype.ID": 429525000000532160,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Yves Muyters",
            "Leavetype": "Verlof - onbetaald",
            "Days": {
                "04-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "04-Dec-2024",
            "EmployeeId": "12",
            "ZUID": 714687561,
            "Employee.ID": 429525000001514300,
            "DateOfRequest": "20-Nov-2023",
            "Zoho_ID": 429525000011741500,
            "Leavetype_ID": 429525000000532160,
            "Employee_ID": 429525000001514300
        },
        {
            "Zoho.ID": 429525000014001000,
            "From": "14-Oct-2024",
            "Leavetype.ID": 429525000000532200,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "PAID",
            "Employee": "Anna Dimby",
            "Leavetype": "Sickness",
            "Days": {
                "14-Oct-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "15-Oct-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "15-Oct-2024",
            "EmployeeId": "2",
            "ZUID": 630148561,
            "Employee.ID": 429525000000130000,
            "DateOfRequest": "16-Oct-2024",
            "Zoho_ID": 429525000014001000,
            "Leavetype_ID": 429525000000532200,
            "Employee_ID": 429525000000130000
        },
        {
            "Zoho.ID": 429525000014510000,
            "From": "11-Feb-2025",
            "Leavetype.ID": 429525000000532160,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Antoine Gerard",
            "Leavetype": "Verlof - onbetaald",
            "Days": {
                "15-Feb-2025": {
                    "LeaveCount": "0.0",
                    "Session": 1
                },
                "18-Feb-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "13-Feb-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "11-Feb-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "14-Feb-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "17-Feb-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "16-Feb-2025": {
                    "LeaveCount": "0.0",
                    "Session": 1
                },
                "12-Feb-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "18-Feb-2025",
            "EmployeeId": "1",
            "ZUID": 48329373,
            "Employee.ID": 429525000000123000,
            "DateOfRequest": "01-Dec-2024",
            "Zoho_ID": 429525000014510000,
            "Leavetype_ID": 429525000000532160,
            "Employee_ID": 429525000000123000
        },
        {
            "Zoho.ID": 429525000014554050,
            "From": "24-Dec-2024",
            "Leavetype.ID": 429525000000532160,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Robin Van Gijseghem ",
            "Leavetype": "Verlof - onbetaald",
            "Days": {
                "24-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "26-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "25-Dec-2024": {
                    "LeaveCount": "0.0",
                    "Session": 1
                }
            },
            "To": "26-Dec-2024",
            "EmployeeId": "17",
            "ZUID": 738663195,
            "Employee.ID": 429525000003851000,
            "DateOfRequest": "05-Dec-2024",
            "Zoho_ID": 429525000014554050,
            "Leavetype_ID": 429525000000532160,
            "Employee_ID": 429525000003851000
        },
        {
            "Zoho.ID": 429525000014277000,
            "From": "05-Nov-2024",
            "Leavetype.ID": 429525000000532200,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "PAID",
            "Employee": "Benjamin Donck",
            "Leavetype": "Sickness",
            "Days": {
                "05-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "05-Nov-2024",
            "EmployeeId": "19",
            "ZUID": 762557813,
            "Employee.ID": 429525000005886000,
            "DateOfRequest": "12-Nov-2024",
            "Zoho_ID": 429525000014277000,
            "Leavetype_ID": 429525000000532200,
            "Employee_ID": 429525000005886000
        },
        {
            "Zoho.ID": 429525000012233000,
            "From": "04-Nov-2024",
            "Leavetype.ID": 429525000000532160,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Yves Muyters",
            "Leavetype": "Verlof - onbetaald",
            "Days": {
                "04-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "05-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "05-Nov-2024",
            "EmployeeId": "12",
            "ZUID": 714687561,
            "Employee.ID": 429525000001514300,
            "DateOfRequest": "25-Jan-2024",
            "Zoho_ID": 429525000012233000,
            "Leavetype_ID": 429525000000532160,
            "Employee_ID": 429525000001514300
        },
        {
            "Zoho.ID": 429525000014034000,
            "From": "12-Dec-2024",
            "Leavetype.ID": 429525000000837000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "PAID",
            "Employee": "Michel Van Steenbergen",
            "Leavetype": "ADV-dagen",
            "Days": {
                "13-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "12-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "13-Dec-2024",
            "EmployeeId": "8",
            "ZUID": 702303420,
            "Employee.ID": 429525000000812000,
            "DateOfRequest": "21-Oct-2024",
            "Zoho_ID": 429525000014034000,
            "Leavetype_ID": 429525000000837000,
            "Employee_ID": 429525000000812000
        },
        {
            "Zoho.ID": 429525000013959200,
            "From": "03-Jan-2025",
            "Leavetype.ID": 429525000000532100,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "PAID",
            "Employee": "Ernst Harnie",
            "Leavetype": "Anciëniteitsverlof",
            "Days": {
                "03-Jan-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "03-Jan-2025",
            "EmployeeId": "4",
            "ZUID": 666449138,
            "Employee.ID": 429525000000132030,
            "DateOfRequest": "16-Oct-2024",
            "Zoho_ID": 429525000013959200,
            "Leavetype_ID": 429525000000532100,
            "Employee_ID": 429525000000132030
        },
        {
            "Zoho.ID": 429525000014722000,
            "From": "02-Jan-2025",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Toky Solofonirina‎",
            "Leavetype": "Holiday Mada",
            "Days": {
                "03-Jan-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "02-Jan-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "03-Jan-2025",
            "EmployeeId": "HRM2",
            "ZUID": 868567453,
            "Employee.ID": 429525000013977000,
            "DateOfRequest": "23-Dec-2024",
            "Zoho_ID": 429525000014722000,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000013977000
        },
        {
            "Zoho.ID": 429525000014192000,
            "From": "16-Oct-2024",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Mendrika Ramiharimanitra",
            "Leavetype": "Holiday Mada",
            "Days": {
                "16-Oct-2024": {
                    "LeaveCount": "0.5",
                    "EndTime": "13:15",
                    "StartTime": "09:00",
                    "Session": 1
                }
            },
            "To": "16-Oct-2024",
            "EmployeeId": "20",
            "ZUID": 762547585,
            "Employee.ID": 429525000006096000,
            "DateOfRequest": "04-Nov-2024",
            "Zoho_ID": 429525000014192000,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000006096000
        },
        {
            "Zoho.ID": 429525000014298200,
            "From": "12-Feb-2025",
            "Leavetype.ID": 429525000000532160,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Yves Muyters",
            "Leavetype": "Verlof - onbetaald",
            "Days": {
                "12-Feb-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "12-Feb-2025",
            "EmployeeId": "12",
            "ZUID": 714687561,
            "Employee.ID": 429525000001514300,
            "DateOfRequest": "13-Nov-2024",
            "Zoho_ID": 429525000014298200,
            "Leavetype_ID": 429525000000532160,
            "Employee_ID": 429525000001514300
        },
        {
            "Zoho.ID": 429525000013959040,
            "From": "15-Oct-2024",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Nambinina Ratovolalao",
            "Leavetype": "Holiday Mada",
            "Days": {
                "15-Oct-2024": {
                    "LeaveCount": "0.5",
                    "EndTime": "13:15",
                    "StartTime": "09:00",
                    "Session": 1
                }
            },
            "To": "15-Oct-2024",
            "EmployeeId": "28",
            "ZUID": 806776542,
            "Employee.ID": 429525000010013000,
            "DateOfRequest": "14-Oct-2024",
            "Zoho_ID": 429525000013959040,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000010013000
        },
        {
            "Zoho.ID": 429525000014227000,
            "From": "12-Nov-2024",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Andriamirado Nomenjanahary",
            "Leavetype": "Holiday Mada",
            "Days": {
                "12-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "12-Nov-2024",
            "EmployeeId": "29",
            "ZUID": 806777619,
            "Employee.ID": 429525000010013000,
            "DateOfRequest": "07-Nov-2024",
            "Zoho_ID": 429525000014227000,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000010013000
        },
        {
            "Zoho.ID": 429525000014340030,
            "From": "21-Nov-2024",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Reason": "Half Day Afternoon - Public Administrative emergency",
            "Type": "UNPAID",
            "Employee": "Ithiel Ramaroharinosy",
            "Leavetype": "Holiday Mada",
            "Days": {
                "21-Nov-2024": {
                    "LeaveCount": "0.5",
                    "EndTime": "13:15",
                    "StartTime": "09:00",
                    "Session": 1
                }
            },
            "To": "21-Nov-2024",
            "EmployeeId": "21",
            "ZUID": 784439171,
            "Employee.ID": 429525000008278000,
            "DateOfRequest": "19-Nov-2024",
            "Zoho_ID": 429525000014340030,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000008278000
        },
        {
            "Zoho.ID": 429525000014298240,
            "From": "12-Mar-2025",
            "Leavetype.ID": 429525000000532160,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Yves Muyters",
            "Leavetype": "Verlof - onbetaald",
            "Days": {
                "12-Mar-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "12-Mar-2025",
            "EmployeeId": "12",
            "ZUID": 714687561,
            "Employee.ID": 429525000001514300,
            "DateOfRequest": "13-Nov-2024",
            "Zoho_ID": 429525000014298240,
            "Leavetype_ID": 429525000000532160,
            "Employee_ID": 429525000001514300
        },
        {
            "Zoho.ID": 429525000011741500,
            "From": "18-Dec-2024",
            "Leavetype.ID": 429525000000532160,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Yves Muyters",
            "Leavetype": "Verlof - onbetaald",
            "Days": {
                "18-Dec-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "18-Dec-2024",
            "EmployeeId": "12",
            "ZUID": 714687561,
            "Employee.ID": 429525000001514300,
            "DateOfRequest": "20-Nov-2023",
            "Zoho_ID": 429525000011741500,
            "Leavetype_ID": 429525000000532160,
            "Employee_ID": 429525000001514300
        },
        {
            "Zoho.ID": 429525000011741440,
            "From": "20-Nov-2024",
            "Leavetype.ID": 429525000000532160,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Yves Muyters",
            "Leavetype": "Verlof - onbetaald",
            "Days": {
                "20-Nov-2024": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "20-Nov-2024",
            "EmployeeId": "12",
            "ZUID": 714687561,
            "Employee.ID": 429525000001514300,
            "DateOfRequest": "20-Nov-2023",
            "Zoho_ID": 429525000011741440,
            "Leavetype_ID": 429525000000532160,
            "Employee_ID": 429525000001514300
        },
        {
            "Zoho.ID": 429525000014456000,
            "From": "04-Dec-2024",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Chrystèle Rakotomalala",
            "Leavetype": "Holiday Mada",
            "Days": {
                "04-Dec-2024": {
                    "LeaveCount": "0.5",
                    "EndTime": "13:15",
                    "StartTime": "09:00",
                    "Session": 1
                }
            },
            "To": "04-Dec-2024",
            "EmployeeId": "24",
            "ZUID": 788509212,
            "Employee.ID": 429525000008507000,
            "DateOfRequest": "28-Nov-2024",
            "Zoho_ID": 429525000014456000,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000008507000
        },
        {
            "Zoho.ID": 429525000014668000,
            "From": "13-Dec-2024",
            "Leavetype.ID": 429525000000532200,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "PAID",
            "Employee": "Nambinina Ratovolalao",
            "Leavetype": "Sickness",
            "Days": {
                "13-Dec-2024": {
                    "LeaveCount": "0.5",
                    "EndTime": "13:15",
                    "StartTime": "09:00",
                    "Session": 1
                }
            },
            "To": "13-Dec-2024",
            "EmployeeId": "28",
            "ZUID": 806776542,
            "Employee.ID": 429525000010013000,
            "DateOfRequest": "16-Dec-2024",
            "Zoho_ID": 429525000014668000,
            "Leavetype_ID": 429525000000532200,
            "Employee_ID": 429525000010013000
        },
        {
            "Zoho.ID": 429525000014818050,
            "From": "06-Jan-2025",
            "Leavetype.ID": 429525000009551000,
            "Unit": "Days",
            "ApprovalStatus": "Approved",
            "Type": "UNPAID",
            "Employee": "Nambinina Ratovolalao",
            "Leavetype": "Holiday Mada",
            "Days": {
                "07-Jan-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                },
                "06-Jan-2025": {
                    "LeaveCount": "1.0",
                    "EndTime": "17:30",
                    "StartTime": "09:00"
                }
            },
            "To": "07-Jan-2025",
            "EmployeeId": "28",
            "ZUID": 806776542,
            "Employee.ID": 429525000010013000,
            "DateOfRequest": "31-Dec-2024",
            "Zoho_ID": 429525000014818050,
            "Leavetype_ID": 429525000009551000,
            "Employee_ID": 429525000010013000
        }
    ]
    """

    );

var dick = new Dictionary<long, byte>();

foreach (var requestObject in requestObjects ?? [])
{
    if (idsInDb.Contains(requestObject.ZohoId.ToString()) is false)
    {
        Console.WriteLine($"this is not in DB {requestObject.ZohoId}");
    }

    if (dick.TryAdd(requestObject.ZohoId, 1) is false)
    {
        Console.WriteLine($"Duplicate ZohoId {requestObject.ZohoId}");
    }
}



Console.WriteLine("Hello, World!");

// BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
//BenchmarkRunner.Run<ForAndForeach>();


class RequestObj
{
    [System.Text.Json.Serialization.JsonPropertyName("Zoho_ID")]
    public long ZohoId { get; set; }
}