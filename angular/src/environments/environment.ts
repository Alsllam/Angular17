import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:5200';

const oAuthConfig = {
  issuer: 'https://localhost:44311/',
  redirectUri: baseUrl,
  clientId: 'SmartApp_App',
  responseType: 'code',
  scope: 'offline_access SmartApp',
  requireHttps: true,
};

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'SmartApp',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44334',
      rootNamespace: 'SmartApp',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
} as Environment;
