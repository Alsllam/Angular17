
const yourIP = 'Your Local IP Address etc 192.168.1.64'; // See the docs https://docs.abp.io/en/abp/latest/Getting-Started-React-Native?Tiered=No
const port  = 44305;
const apiUrl = `http://${yourIP}:${port}`;
const ENV = {
  dev: {
    apiUrl: apiUrl,
    oAuthConfig: {
      issuer: apiUrl,
      clientId: 'SmartApp_App',
      scope: 'offline_access SmartApp',
    },
    localization: {
      defaultResourceName: 'SmartApp',
    },
  },
  prod: {
    apiUrl: 'http://localhost:44334',
    oAuthConfig: {
      issuer: 'http://localhost:44311',
      clientId: 'SmartApp_App',
      scope: 'offline_access SmartApp',
    },
    localization: {
      defaultResourceName: 'SmartApp',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
