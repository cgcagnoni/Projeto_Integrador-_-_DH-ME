import axios from "axios";
const api = axios.create({
 baseURL: "https://localhost:7288/api/Usuario/Login",
});

// api.interceptors.request.use(
//  (config) => {
//    config.headers.Authorization = `Bearer ${token}`;

//    return config;
//  },
//  (error) => {
//    return Promise.reject(error);
//  }
// );

export default api;