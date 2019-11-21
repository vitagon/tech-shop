import Axios from 'axios';

export function getCategoryByName(name) {
  return Axios.get(`/api/categories/name/${name}`)
    .then(result => {
      return result.data;
    });
}