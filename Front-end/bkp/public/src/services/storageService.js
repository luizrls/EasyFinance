const storageService = {
  setItem: (key, value) => sessionStorage.setItem(key, value),
  getItem: (key) => sessionStorage.getItem(key),
};

export default storageService;
