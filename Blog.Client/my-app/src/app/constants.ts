const isLocal = ['localhost', '127.0.0.1'].includes(window.location.hostname);
const apiOrigin = isLocal
  ? 'https://localhost:7054'
  : 'https://webapi.cihangokpinar.com';

export const api: string = `${apiOrigin}/api`;
export const urlForImg: string = `${apiOrigin}/`;
