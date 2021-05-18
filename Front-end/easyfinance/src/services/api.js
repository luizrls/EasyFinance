import axios from "axios";

export const urlBase = "https://localhost:44356/api";

const api = axios.create({
  baseURL: urlBase,
});

/* api.interceptors.request.use(async (config) => {
  const token = sessionStorage.getItem("msalToken");
  config.headers.Authorization = `Bearer ${token}`;
  return config;
}); */

export default api;
